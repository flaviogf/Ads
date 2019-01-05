import React, { Component } from 'react';

//axios
import axios from 'axios';

//url api
const URL = 'https://agi-bi-backend.herokuapp.com/arquivo';

class ListaArquivo extends Component {
    constructor(props) {
        super(props);

        this.state = { arquivos: [] };

        this.find = this.find.bind(this);
    }

    componentWillMount() {
        this.find();
    }

    find() {
        axios.get(URL)
        .then(response => this.setState({ arquivos: response.data }))
        .catch(() => console.log('erro ao buscar os arquivos'));
    }

    render() {
        const { arquivos } = this.state;

        if(arquivos.length <= 0) {
            return (
                <div className="container">
                    <i className="center-block fa fa-circle-o-notch fa-spin fa-3x fa-fw"></i>
                </div>
            );
        }
        else if(Array.isArray(arquivos)) {
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
                            arquivos.map(arquivo => (
                                <tr key={arquivo._id}>
                                    <td>{arquivo._id}</td>
                                    <td>{arquivo.nome}</td>
                                </tr>
                            ))
                        }
                    </tbody>
                </table>
            );
        }
        else {
            return (
                <tr key={arquivos._id}>
                    <td>{arquivos._id}</td>
                    <td>{arquivos.nome}</td>
                </tr>
            );
        }
    }
}

export default ListaArquivo;
