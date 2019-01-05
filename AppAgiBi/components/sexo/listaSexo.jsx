import React, { Component } from 'react';

//axios
import axios from 'axios';

//url api
const URL = 'https://agi-bi-backend.herokuapp.com/sexo';

class ListaSexo extends Component {
    constructor(props) {
        super(props);

        this.state = { sexos: [] };

        this.find = this.find.bind(this);
    }

    componentWillMount() {
        this.find();
    }

    find() {
        axios.get(URL)
        .then(response => this.setState({ sexos: response.data }))
        .catch(() => console.log('erro ao buscar os sexos'));
    }

    render() {
        const { sexos } = this.state;

        if(sexos.length <= 0) {
            return (
                <div className="container">
                    <i className="center-block fa fa-circle-o-notch fa-spin fa-3x fa-fw"></i>
                </div>
            );
        }
        else if(Array.isArray(sexos)) {
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
                            sexos.map(sexo => (
                                <tr key={sexo._id}>
                                    <td>{sexo._id}</td>
                                    <td>{sexo.nome}</td>
                                </tr>
                            ))
                        }
                    </tbody>
                </table>
            );
        }
        else {
            return (
                <tr key={sexos._id}>
                    <td>{sexos._id}</td>
                    <td>{sexos.nome}</td>
                </tr>
            );
        }
    }
}

export default ListaSexo;
