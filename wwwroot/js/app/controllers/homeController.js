var rodeioApp = angular.module('rodeioApp', ['ngAnimate', 'toastr']);

rodeioApp.controller('homeController', function ($scope, $timeout, toastr) {

    $scope.listTipoCabelo = [];
    $scope.listTipoComprimentoCabelo = [];
    $scope.listTipoCorCabelo = [];
    $scope.listEscolaridade = [];
    $scope.listTipoCorPele = [];


    $scope.getTipoCabelo = function () {
        $.ajax({
            url: '/Home/GetTipoCabelo',
            type: 'POST',
            success: function (result) {
                $scope.listTipoCabelo = result;
                $scope.$apply();
            },
            error: function (xhr, status) {

            }
        });
    }
    $scope.getTipoCabelo();

    $scope.getTipoComprimentoCabelo = function () {
        $.ajax({
            url: '/Home/GetTipoComprimentoCabelo',
            type: 'POST',
            success: function (result) {
                $scope.listTipoComprimentoCabelo = result;
                $scope.$apply();
            },
            error: function (xhr, status) {

            }
        });
    }
    $scope.getTipoComprimentoCabelo();

    $scope.getTipoCorCabelo = function () {
        $.ajax({
            url: '/Home/GetTipoCorCabelo',
            type: 'POST',
            success: function (result) {
                $scope.listTipoCorCabelo = result;
                $scope.$apply();
            },
            error: function (xhr, status) {

            }
        });
    }
    $scope.getTipoCorCabelo();

    $scope.getEscolaridade = function () {
        $.ajax({
            url: '/Home/GetEscolaridade',
            type: 'POST',
            success: function (result) {
                $scope.listEscolaridade = result;
                $scope.$apply();
            },
            error: function (xhr, status) {

            }
        });
    }
    $scope.getEscolaridade();

    $scope.getTipoCorPele = function () {
        $.ajax({
            url: '/Home/GetTipoCorPele',
            type: 'POST',
            success: function (result) {
                $scope.listTipoCorPele = result;
                $scope.$apply();
            },
            error: function (xhr, status) {

            }
        });
    }
    $scope.getTipoCorPele();

    $scope.getTipoCorOlho = function () {
        $.ajax({
            url: '/Home/GetTipoCorOlho',
            type: 'POST',
            success: function (result) {
                $scope.listTipoCorOlho = result;
                $scope.$apply();
            },
            error: function (xhr, status) {

            }
        });
    }
    $scope.getTipoCorOlho();



    $scope.salvar = function () {

        var title = "Cadastro de Departamento";

        if (this.comboEscolaridade == "" || this.comboEscolaridade == undefined) {
            $('#comboEscolaridade').focus();
            toastr.error("O campo ESCOLARIDADE é obrigatório.", "Inscrição");
            return;
        }
        if (this.comboOlhos == "" || this.comboOlhos == undefined) {
            $('#comboOlhos').focus();
            toastr.error("O campo COR DOS OLHOS é obrigatório.", "Inscrição");
            return;
        }
        if (this.comboPele == "" || this.comboPele == undefined) {
            $('#comboPele').focus();
            toastr.error("O campo COR DA PELE é obrigatório.", "Inscrição");
            return;
        }
        if (this.comboTamanhoCabelo == "" || this.comboTamanhoCabelo == undefined) {
            $('#comboTamanhoCabelo').focus();
            toastr.error("O campo TAMANHO DO CABELO é obrigatório.", "Inscrição");
            return;
        }
        if (this.comboTipoCabelo == "" || this.comboTipoCabelo == undefined) {
            $('#comboTipoCabelo').focus();
            toastr.error("O campo TIPO DO CABELO é obrigatório.", "Inscrição");
            return;
        }
        if (this.comboCorCabelo == "" || this.comboCorCabelo == undefined) {
            $('#comboCorCabelo').focus();
            toastr.error("O campo COR DO CABELO é obrigatório.", "Inscrição");
            return;
        }


        if (this.Nome == "" || this.Nome == undefined) {
            $('#formNome').focus();
            toastr.error("O campo NOME é obrigatório.", "Inscrição");
            return;
        }
        if (this.Endereco == "" || this.Endereco == undefined) {
            $('#formEndereco').focus();
            toastr.error("O campo ENDEREÇO é obrigatório.", "Inscrição");
            return;
        }
        if (this.Bairro == "" || this.Bairro == undefined) {
            $('#formBairro').focus();
            toastr.error("O campo BAIRRO é obrigatório.", "Inscrição");
            return;
        }
        if (this.Cidade == "" || this.Cidade == undefined) {
            $('#formCidade').focus();
            toastr.error("O campo CIDADE é obrigatório.", "Inscrição");
            return;
        }
        if (this.UF == "" || this.UF == undefined) {
            $('#formUf').focus();
            toastr.error("O campo UF é obrigatório.", "Inscrição");
            return;
        }
        if (this.CEP == "" || this.CEP == undefined) {
            $('#formCep').focus();
            toastr.error("O campo CEP é obrigatório.", "Inscrição");
            return;
        }
        if (this.Celular == "" || this.Celular == undefined) {
            $('#formCelular').focus();
            toastr.error("O campo CELULAR é obrigatório.", "Inscrição");
            return;
        }
        if (this.Email == "" || this.Email == undefined) {
            $('#formEmail').focus();
            toastr.error("O campo EMAIL é obrigatório.", "Inscrição");
            return;
        }
        if (this.RG == "" || this.RG == undefined) {
            $('#formRg').focus();
            toastr.error("O campo RG é obrigatório.", "Inscrição");
            return;
        }
        if (this.DataNascimento == "" || this.DataNascimento == undefined) {
            $('#formDataNascimento').focus();
            toastr.error("O campo DATA DE NASCIMENTO é obrigatório.", "Inscrição");
            return;
        }
        if (this.Idade == "" || this.Idade == undefined) {
            $('#formIdade').focus();
            toastr.error("O campo IDADE é obrigatório.", "Inscrição");
            return;
        }
        if (this.Altura == "" || this.Altura == undefined) {
            $('#formAltura').focus();
            toastr.error("O campo ALTURA é obrigatório.", "Inscrição");
            return;
        }
        if (this.Peso == "" || this.Peso == undefined) {
            $('#formPeso').focus();
            toastr.error("O campo PESO é obrigatório.", "Inscrição");
            return;
        }
        if (this.Manequim == "" || this.Manequim == undefined) {
            $('#formManequim').focus();
            toastr.error("O campo MANEQUIM é obrigatório.", "Inscrição");
            return;
        }
        if (this.Calcado == "" || this.Calcado == undefined) {
            $('#formCalcado').focus();
            toastr.error("O campo CALÇADO é obrigatório.", "Inscrição");
            return;
        }
        if (this.Chapeu == "" || this.Chapeu == undefined) {
            $('#formChapeu').focus();
            toastr.error("O campo CHAPÉU é obrigatório.", "Inscrição");
            return;
        }
        if (this.Busto == "" || this.Busto == undefined) {
            $('#formBusto').focus();
            toastr.error("O campo BUSTO é obrigatório.", "Inscrição");
            return;
        }
        if (this.Cintura == "" || this.Cintura == undefined) {
            $('#formCintura').focus();
            toastr.error("O campo CINTURA é obrigatório.", "Inscrição");
            return;
        }
        if (this.Quadril == "" || this.Quadril == undefined) {
            $('#formQuadril').focus();
            toastr.error("O campo QUADRIL é obrigatório.", "Inscrição");
            return;
        }

        var data = {
            Nome: this.Nome,
            Rg: this.RG,
            DataNascimento: this.DataNascimento,
            Celular: this.Celular,
            Fone: this.Fone,
            Endereco: this.Endereco,
            Bairro: this.Bairro,
            Cep: this.CEP,
            IdCidade: this.comboCidade,
            Ativo: true,
            IdEscolaridade: this.comboEscolaridade,
            Peso: this.Peso,
            IdTipoCorOlho: this.comboOlhos,
            IdTipoPele: this.comboPele,
            Manequim: this.Manequim,
            NumeroCalcado: this.Calcado,
            NumeroChapeu: this.Chapeu,
            MedidaBust: this.Busto,
            MedidaCintura: this.Cintura,
            MedidaQuadril: this.Quadril
        };

        $.ajax({
            url: '/Home/Save',
            type: 'POST',
            data: data,
            success: function (result) {
                
                $scope.clear();
                toastr.success(result.Mensagem, result.Titulo);
                alert('FOI ESSA PORRA PODE DAR SELECT NA BASE!!!!!!');
                //$('#modalDepartamento').modal('hide');
            },
            error: function (xhr, status) {

            }
        })
    };



    $scope.clear = function () {
        this.Nome,
        this.RG,
        this.DataNascimento,
        this.Celular,
        this.Fone,
        this.Endereco,
        this.Bairro,
        this.CEP,
        this.comboCidade,
        this.comboEscolaridade,
        this.Peso,
        this.comboOlhos,
        this.comboPele,
        this.Manequim,
        this.Calcado,
        this.Chapeu,
        this.Busto,
        this.Cintura,
        this.Quadril
        $('#formNome').focus();
    };
});