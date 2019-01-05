import React, { Component } from 'react';

class Acoes extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div className="btn-group">
                <button
                    type="button"
                    className="btn btn-default"
                    onClick={() => this.props.insert()}>Inserir registros</button>
                <a 
                    className="btn btn-default"
                    href="https://agi-bi-backend.herokuapp.com/tabela.txt"
                    download="tabela">Salvar registro</a>
                <button type="button"
                    className="btn btn-default"
                    onClick={() => this.props.findMore()}>Carregar mais registros</button>
            </div>
        )
    }
}

export default Acoes;
