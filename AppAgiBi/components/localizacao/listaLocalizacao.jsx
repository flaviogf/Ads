import React, { Component } from 'react';

//axios
import axios from 'axios';

//url api
const URL = 'https://agi-bi-backend.herokuapp.com/localizacao';

class ListaLocalizacao extends Component {
    constructor(props) {
        super(props);

        this.state = { localizacoes: [] };

        this.find = this.find.bind(this);
    }

    componentWillMount() {
        this.find();
    }

    find() {
        axios.get(URL)
        .then(response => this.setState({ localizacoes: response.data }))
        .catch(() => console.log('erro ao buscar as localizacoes'));
    }

    render() {
        const { localizacoes } = this.state;

        if(localizacoes.length <= 0) {
            return (
                <div className="container">
                    <i className="center-block fa fa-circle-o-notch fa-spin fa-3x fa-fw"></i>
                </div>
            );
        }
        else if(Array.isArray(localizacoes)) {
            return (
                <table className="table table-striped table-hover">
                    <thead>
                        <tr>
                            <th>Codigo</th>
                            <th>Nome</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            localizacoes.map(localizacao => (
                                <tr key={localizacao._id}>
                                    <td>{localizacao._id}</td>
                                    <td>{localizacao.nome}</td>
                                </tr>
                            ))
                        }
                    </tbody>
                </table>
            );
        }
        else {
            return (
                <tr key={localizacoes._id}>
                    <td>{localizacoes._id}</td>
                    <td>{localizacoes.nome}</td>
                </tr>
            );
        }
    }
}

export default ListaLocalizacao;
