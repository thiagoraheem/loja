using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.DAO
{
    class claProdutos
    {
        String _codproduto;
        public String Codproduto
        {
            get { return _codproduto; }
            set { _codproduto = value; }
        }

        String _desproduto;
        public String Desproduto
        {
            get { return _desproduto; }
            set { _desproduto = value; }
        }

        String _deslocal;
        public String Deslocal
        {
            get { return _deslocal; }
            set { _deslocal = value; }
        }

        Nullable<double> _vlrunitario;
        public Nullable<double> Vlrunitario
        {
            get { return _vlrunitario; }
            set { _vlrunitario = value; }
        }

        Nullable<double> _qtdproduto;
        public Nullable<double> Qtdproduto
        {
            get { return _qtdproduto; }
            set { _qtdproduto = value; }
        }

        Nullable<double> _vlrcusto;
        public Nullable<double> Vlrcusto
        {
            get { return _vlrcusto; }
            set { _vlrcusto = value; }
        }

        Nullable<double> _vlrpercent;
        public Nullable<double> Vlrpercent
        {
            get { return _vlrpercent; }
            set { _vlrpercent = value; }
        }

        Nullable<double> _estminimo;
        public Nullable<double> Estminimo
        {
            get { return _estminimo; }
            set { _estminimo = value; }
        }

        String _datcadastro;
        public String DatCadastro
        {
            get { return _datcadastro; }
            set { _datcadastro = value; }
        }

        String _desfornecedor;
        public String Desfornecedor
        {
            get { return _desfornecedor; }
            set { _desfornecedor = value; }
        }

        String _codrefantiga;
        public String Codrefantiga
        {
            get { return _codrefantiga; }
            set { _codrefantiga = value; }
        }

        Nullable<double> _desfaz;
        public Nullable<double> Desfaz
        {
            get { return _desfaz; }
            set { _desfaz = value; }
        }

        Nullable<double> _vlrultpreco;
        public Nullable<double> Vlrultpreco
        {
            get { return _vlrultpreco; }
            set { _vlrultpreco = value; }
        }

        object _imagem;
        public object Imagem
        {
            get { return _imagem; }
            set { _imagem = value; }
        }

        public claProdutos(string codproduto, string desproduto, string deslocal, Nullable<double> vlrunitario,
                            Nullable<double> qtdproduto, Nullable<double> vlrcusto, Nullable<double> vlrpercent,
                            Nullable<double> estminimo, string datcadastro, string desfornecedor, string codrefantiga,
                            Nullable<double> desfaz, Nullable<double> vlrultpreco, Object imagem) {
            this._codproduto = codproduto;
            this._desproduto = desproduto;
            this._deslocal = deslocal;
            this._vlrunitario = vlrunitario;
            this._qtdproduto = qtdproduto;
            this._vlrcusto = vlrcusto;
            this._vlrpercent = vlrpercent;
            this._estminimo = estminimo;
            this._datcadastro = datcadastro;
            this._desfornecedor = desfornecedor;
            this._codrefantiga = codrefantiga;
            this._desfaz = desfaz;
            this._vlrultpreco = vlrultpreco;
            this._imagem = imagem;
        
        }

        public claProdutos() { }
    }

    class claOrcamento
    {
        String _codorca;
        public String CodOrca
        {
            get { return _codorca; }
            set { _codorca = value; }
        }

        String _codproduto;
        public String CodProduto
        {
            get { return _codproduto; }
            set { _codproduto = value; }
        }

        String _descproduto;
        public String DescProduto
        {
            get { return _descproduto; }
            set { _descproduto = value; }
        }

        Nullable<double> _quantidade;
        public Nullable<double> Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        Nullable<double> _vlrunitario;
        public Nullable<double> VlrUnitario
        {
            get { return _vlrunitario; }
            set { _vlrunitario = value; }
        }

        Nullable<double> _vlrcusto;
        public Nullable<double> VlrCusto
        {
            get { return _vlrcusto; }
            set { _vlrcusto = value; }
        }

        String _deslocal;
        public String DesLocal
        {
            get { return _deslocal; }
            set { _deslocal = value; }
        }

        Nullable<double> _pf;
        public Nullable<double> Pf
        {
            get { return _pf; }
            set { _pf = value; }
        }

        String _flgstatus;
        public String FlgStatus
        {
            get { return _flgstatus; }
            set { _flgstatus = value; }
        }

        Nullable<DateTime> _datorca;
        public Nullable<DateTime> DatOrca
        {
            get { return _datorca; }
            set { _datorca = value; }
        }

    }

    class claTipoVenda
    {
        int _codtipovenda;
        public int CodTipoVenda
        {
            get { return _codtipovenda; }
            set { _codtipovenda = value; }
        }

        String _destipovenda;
        public String DesTipoVenda
        {
            get { return _destipovenda; }
            set { _destipovenda = value; }
        }

        Boolean _flgativo;
        public Boolean flgAtivo
        {
            get { return _flgativo; }
            set { _flgativo = value; }
        }

        Boolean _flgavista;
        public Boolean flgAVista
        {
            get { return _flgavista; }
            set { _flgavista = value; }
        }

        Nullable<Double> _qtddias;
        public Nullable<Double> QtdDias
        {
            get { return _qtddias; }
            set { _qtddias = value; }
        }

    }



}
