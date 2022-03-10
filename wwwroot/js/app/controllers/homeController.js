var rodeioApp = angular.module('rodeioApp', ['ngAnimate', 'toastr']);

rodeioApp.controller('homeController', function ($scope, $timeout, toastr, $compile) {

    $scope.listTipoCabelo = [];
    $scope.listTipoComprimentoCabelo = [];
    $scope.listTipoCorCabelo = [];
    $scope.listEscolaridade = [];
    $scope.listTipoCorPele = [];

    $scope.disposeModalSuccess = function () {
        $('#modalSuccess').modal('toggle');
    };

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

        if (this.Nome == "" || this.Nome == undefined) {
            $('#formNome').focus();
            alertErro("NOME");
            return;
        }
        if (this.Endereco == "" || this.Endereco == undefined) {
            $('#formEndereco').focus();
            alertErro("ENDERECO");
            return;
        }
        if (this.Bairro == "" || this.Bairro == undefined) {
            $('#formBairro').focus();
            alertErro("BAIRRO");
            return;
        }
        if (this.Cidade == "" || this.Cidade == undefined) {
            $('#formCidade').focus();
            alertErro("CIDADE");
            return;
        }
        if (this.UF == "" || this.UF == undefined) {
            $('#formUf').focus();
            alertErro("UF");
            return;
        }
        if (this.CEP == "" || this.CEP == undefined) {
            $('#formCep').focus();
            alertErro("CEP");
            return;
        }
        if (this.Celular == "" || this.Celular == undefined) {
            $('#formCelular').focus();
            alertErro("CELULAR");
            return;
        }
        if (this.Fone == "" || this.Fone == undefined) {
            $('#formCelular').focus();
            alertErro("FONE");
            return;
        }
        if (this.Email == "" || this.Email == undefined) {
            $('#formEmail').focus();
            alertErro("EMAIL");
            return;
        }
        if (this.RG == "" || this.RG == undefined) {
            $('#formRg').focus();
            alertErro("RG");
            return;
        }
        if (this.CPF == "" || this.CPF == undefined) {
            $('#formRg').focus();
            alertErro("CPF");
            return;
        }
        if (this.DataNascimento == "" || this.DataNascimento == undefined) {
            $('#formDataNascimento').focus();
            alertErro("DATA DE NASCIMENTO");
            return;
        }
        if (this.Idade == "" || this.Idade == undefined) {
            $('#formIdade').focus();
            alertErro("IDADE");
            return;
        }

        if (this.comboEscolaridade == "" || this.comboEscolaridade == undefined) {
            $('#comboEscolaridade').focus();
            setInterval(ShowModalAlert, 500)
            toastr.error("O campo ESCOLARIDADE é obrigatório.", "Inscrição");
            return;
        }

        if (this.Altura == "" || this.Altura == undefined) {
            $('#formAltura').focus();
            alertErro("ALTURA");
            return;
        }
        if (this.Peso == "" || this.Peso == undefined) {
            $('#formPeso').focus();
            alertErro("PESO");
            return;
        }

        if (this.comboOlhos == "" || this.comboOlhos == undefined) {
            $('#comboOlhos').focus();
            setInterval(ShowModalAlert, 500)
            alertErro("COR DOS OLHOS");
            return;
        }
        if (this.comboPele == "" || this.comboPele == undefined) {
            $('#comboPele').focus();
            setInterval(ShowModalAlert, 500)
            alertErro("COR DA PELE");
            return;
        }

        if (this.Manequim == "" || this.Manequim == undefined) {
            $('#formManequim').focus();
            alertErro("MANEQUIM");
            return;
        }
        if (this.Calcado == "" || this.Calcado == undefined) {
            $('#formCalcado').focus();
            alertErro("CALÇADO");
            return;
        }
        if (this.Chapeu == "" || this.Chapeu == undefined) {
            $('#formChapeu').focus();
            alertErro("CHAPÉU");
            return;
        }

        if (this.comboTamanhoCabelo == "" || this.comboTamanhoCabelo == undefined) {
            $('#comboTamanhoCabelo').focus();
            setInterval(ShowModalAlert, 500)
            alertErro("TAMANHO DO CABELO");
            return;
        }
        if (this.comboTipoCabelo == "" || this.comboTipoCabelo == undefined) {
            $('#comboTipoCabelo').focus();
            setInterval(ShowModalAlert, 500)
            alertErro("TIPO DO CABELO");
            return;
        }
        if (this.comboCorCabelo == "" || this.comboCorCabelo == undefined) {
            $('#comboCorCabelo').focus();
            setInterval(ShowModalAlert, 500)
            alertErro("COR DO CABELO");
            return;
        }

        if (this.Busto == "" || this.Busto == undefined) {
            $('#formBusto').focus();
            alertErro("BUSTO");
            return;
        }
        if (this.Cintura == "" || this.Cintura == undefined) {
            $('#formCintura').focus();
            alertErro("CINTURA");
            return;
        }
        if (this.Quadril == "" || this.Quadril == undefined) {
            $('#formQuadril').focus();
            alertErro("QUADRIL");
            return;
        }

        if ($('#imgupload')[0].files.length === 0) {
            $("#imgupload").focus();
            alertErro("FOTO");
        }


        var cpfFormatado = this.CPF.replace(/[`~!@#$%^&*()_|+\-=?;:'",.<>\{\}\[\]\\\/]/gi, '');
        var foneFormatado = this.Fone.replace(/[`~!@#$%^&*()_|+\-=?;:'",.<>\{\}\[\]\\\/]/gi, '');
        var celularFormatado = this.Celular.replace(/[`~!@#$%^&*()_|+\-=?;:'",.<>\{\}\[\]\\\/]/gi, '');
        var cepFormatado = this.CEP.replace(/[`~!@#$%^&*()_|+\-=?;:'",.<>\{\}\[\]\\\/]/gi, '');

        var data = {

            Nome: this.Nome,
            Endereco: this.Endereco,
            Bairro: this.Bairro,
            Cidade: this.Cidade,
            Cep: cepFormatado,
            UF: this.UF,
            Fone: foneFormatado,
            Celular: celularFormatado,
            Email: this.Email,
            RG: this.RG,
            CPF: cpfFormatado,
            DataNascimento: this.DataNascimento,
            Idade: this.Idade,
            IdEscolaridade: this.comboEscolaridade,
            Peso: this.Peso,
            Altura: this.Altura,
            IdTipoCorOlho: this.comboOlhos,
            IdTipocorPele: this.comboPele,
            Manequim: this.Manequim,
            NumeroCalcado: this.Calcado,
            NumeroChapeu: this.Chapeu,
            IdTipoComprimentoCabelo: this.comboTamanhoCabelo,
            IdTipoCabelo: this.comboTipoCabelo,
            IdTipoCorCabelo: this.comboCorCabelo,
            MedidaBusto: this.Busto,
            MedidaCintura: this.Cintura,
            MedidaQuadril: this.Quadril,
        };

        var fileUpload = $("#imgupload").get(0);
        var files = fileUpload.files;
        var formData = new FormData();
        formData.append(files[0].name, files[0]);
        formData.append('Dados', JSON.stringify(data));

        $.ajax({
            url: '/Home/Save',
            type: 'POST',
            contentType: false, // Not to set any content header  
            processData: false, // Not to process data  
            data: formData,
            success: function (result) {
                $scope.clear();

                $scope.getTipoCabelo();
                $scope.getTipoComprimentoCabelo();
                $scope.getTipoCorCabelo();
                $scope.getTipoCorPele();
                $scope.getTipoCorOlho();
                debugger
                $.ajax({
                    url: '/Home/GetLastId',
                    type: 'POST',
                    success: function (result2) {
                        jNotify.success('Inscrição concluída!', 'A sua inscrição foi confirmada, seu número é: '+result2[0].id+'! Foi enviado um email com'
                            + 'o comprovante de inscrição para o email informado no formulário'
                            + ', caso não tenha recebido, entre em contato pelo Whatsapp.', {
                                delay: 10000
                        })
                    }
                })  
            },
            error: function (xhr, status) {
                alert('Houve um erro na sua inscrição.');
            }
        })
    };

    $scope.clear = function () {
        this.Nome = "";
        this.RG = "";
        this.DataNascimento = "";
        this.Celular = "";
        this.Fone = "";
        this.Endereco = "";
        this.Bairro = "";
        this.CEP = "";
        this.Cidade = "";
        this.Email = "";
        this.CPF = "";
        this.Idade = "";
        this.UF = "";
        this.Altura = "";
        this.comboCidade = "";
        this.comboEscolaridade = "";
        this.Peso = "";
        this.comboOlhos = "";
        this.comboPele = "";
        this.Manequim = "";
        this.Calcado = "";
        this.Chapeu = "";
        this.Busto = "";
        this.Cintura = "";
        this.Quadril = "";      
        $('#formNome').focus();
    };
});