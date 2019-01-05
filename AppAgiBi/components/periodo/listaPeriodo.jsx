import React, { Component } from 'react';

//axios
import axios from 'axios';

//url api
const URL = 'https://agi-bi-backend.herokuapp.com/periodo';

class ListaPeriodo extends Component {
    constructor(props) {
        super(props);

        this.state = { periodos: [] };

        this.find = this.find.bind(this);
    }

    componentWillMount() {
        this.find();
    }

    find() {
        axios.get(URL)
        .then(response => this.setState({ periodos: response.data }))
        .catch(() => console.log('erro ao buscar os periodos'));
    }

    render() {
        const { periodos } = this.state;

        if(periodos.length <= 0) {
            return (
                <div className="container">
                    <i className="center-block fa fa-circle-o-notch fa-spin fa-3x fa-fw"></i>
                </div>
            );
        }
        else if(Array.isArray(periodos)) {
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
                            periodos.map(periodo => (
                                <tr key={periodo._id}>
                                    <td>{periodo._id}</td>
                                    <td>{periodo.nome}</td>
                                </tr>
                            ))
                        }
                    </tbody>
                </table>
            );
        }
        else {
            return (
                <tr key={periodos._id}>
                    <td>{periodos._id}</td>
                    <td>{periodos.nome}</td>
                </tr>
            );
        }
    }
}

export default ListaPeriodo;
