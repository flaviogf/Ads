import React, { Component } from 'react';

//axios
import axios from 'axios';

//url api
const URL = 'https://agi-bi-backend.herokuapp.com/categoria';

class ListaCategoria extends Component {
    constructor(props) {
        super(props);

        this.state = { categorias: [] };

        this.find = this.find.bind(this);
    }

    componentWillMount() {
        this.find();
    }

    find() {
        axios.get(URL)
        .then(response => this.setState({ categorias: response.data }))
        .catch(() => console.log('erro ao buscar as categorias'));
    }

    render() {
        const { categorias } = this.state;

        if(categorias.length <= 0) {
            return (
                <div className="container">
                    <i className="center-block fa fa-circle-o-notch fa-spin fa-3x fa-fw"></i>
                </div>
            );
        }
        else if(Array.isArray(categorias)) {
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
                            categorias.map(categoria => (
                                <tr key={categoria._id}>
                                    <td>{categoria._id}</td>
                                    <td>{categoria.nome}</td>
                                </tr>
                            ))
                        }
                    </tbody>
                </table>
            );
        }
        else {
            return (
                <tr key={categorias._id}>
                    <td>{categorias._id}</td>
                    <td>{categorias.nome}</td>
                </tr>
            );
        }
    }
}

export default ListaCategoria;
