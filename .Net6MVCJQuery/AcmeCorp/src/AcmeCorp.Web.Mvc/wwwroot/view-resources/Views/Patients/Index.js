(function ($) {
    var _patientService = abp.services.app.patient,
        l = abp.localization.getSource('AcmeCorp'),
        _$modal = $('#PatientCreateModal'),
        _$form = _$modal.find('form'),
        _$table = $('#PatientsTable');

    var _$patientsTable = _$table.DataTable({
        paging: true,
        serverSide: true,
        listAction: {
            ajaxFunction: _patientService.getAll,
            inputFilter: function () {
                return $('#PatientsSearchForm').serializeFormToObject(true);
            }
        },
        buttons: [
            {
                name: 'refresh',
                text: '<i class="fas fa-redo-alt"></i>',
                action: () => _$patientTable.draw(false)
            }
        ],
        responsive: {
            details: {
                type: 'column'
            }
        },
        columnDefs: [
            {
                targets: 0,
                className: 'control',
                defaultContent: '',
            },
            {
                targets: 1,
                data: 'patientId',
                sortable: true
            },
            {
                targets: 2,
                data: 'patientName',
                sortable: true
            },
            {
                targets: 3,
                data: 'dateOfBirth',
                sortable: false,
                displayFormat: 'DD/MM/YYYY',
            },
            {
                targets: 4,
                data: 'gender',
                sortable: false
            },
            {
                targets: 5,
                data: 'isActive',
                sortable: false,
                render: data => `<input type="checkbox" disabled ${data ? 'checked' : ''}>`
            },
            {
                targets: 6,
                data: null,
                sortable: false,
                autoWidth: false,
                defaultContent: '',
                render: (data, type, row, meta) => {
                    return [
                        `   <button type="button" class="btn btn-sm bg-secondary edit-patient" data-patient-id="${row.id}" data-toggle="modal" data-target="#PatientEditModal">`,
                        `       <i class="fas fa-pencil-alt"></i> ${l('Edit')}`,
                        '   </button>',
                        `   <button type="button" class="btn btn-sm bg-danger delete-patient" data-patient-id="${row.id}" data-patient-name="${row.patientName}">`,
                        `       <i class="fas fa-trash"></i> ${l('Delete')}`,
                        '   </button>'
                    ].join('');
                }
            }
        ]
    });

    _$form.validate({
        rules: {
            Password: "required",
            ConfirmPassword: {
                equalTo: "#Password"
            }
        }
    });

    _$form.find('.save-button').on('click', (e) => {
        e.preventDefault();

        if (!_$form.valid()) {
            return;
        }

        var patient = _$form.serializeFormToObject();

        abp.ui.setBusy(_$modal);
        _patientService.create(patient).done(function () {
            _$modal.modal('hide');
            _$form[0].reset();
            abp.notify.info(l('SavedSuccessfully'));
            _$patientsTable.ajax.reload();
        }).always(function () {
            abp.ui.clearBusy(_$modal);
        });
    });

    $(document).on('click', '.delete-patient', function () {
        var patientId = $(this).attr("data-patient-id");
        var patientName = $(this).attr('data-patient-name');

        deletePatient(patientId, patientName);
    });

    function deletePatient(patientId, patientName) {
        abp.message.confirm(
            abp.utils.formatString(
                l('AreYouSureWantToDelete'),
                patientName),
            null,
            (isConfirmed) => {
                if (isConfirmed) {
                    _patientService.delete({
                        id: patientId
                    }).done(() => {
                        abp.notify.info(l('SuccessfullyDeleted'));
                        _$usersTable.ajax.reload();
                    });
                }
            }
        );
    }

    $(document).on('click', '.edit-patient', function (e) {
        var patientId = $(this).attr("data-patient-id");

        e.preventDefault();
        abp.ajax({
            url: abp.appPath + 'Patients/EditModal?patientId=' + patientId,
            type: 'POST',
            dataType: 'html',
            success: function (content) {
                $('#PatientEditModal div.modal-content').html(content);
            },
            error: function (e) {
            }
        });
    });

    $(document).on('click', 'a[data-target="#PatientCreateModal"]', (e) => {
        $('.nav-tabs a[href="#patient-details"]').tab('show')
    });

    abp.event.on('patient.edited', (data) => {
        _$patientsTable.ajax.reload();
    });

    _$modal.on('shown.bs.modal', () => {
        _$modal.find('input:not([type=hidden]):first').focus();
    }).on('hidden.bs.modal', () => {
        _$form.clearForm();
    });

    $('.btn-search').on('click', (e) => {
        _$patientsTable.ajax.reload();
    });

    $('.txt-search').on('keypress', (e) => {
        if (e.which == 13) {
            _$patientsTable.ajax.reload();
            return false;
        }
    });
})(jQuery);
