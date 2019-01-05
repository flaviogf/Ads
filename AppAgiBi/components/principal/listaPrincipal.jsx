import React, { Component } from 'react';

//axios
import axios from 'axios';

//declarações
const URL = 'https://agi-bi-backend.herokuapp.com/principal';
let pular = 0;

//componentes
import Acoes from './acoes';

class ListaPrincipal extends Component {
    constructor(props) {
        super(props);

        this.state = { itens: [] };

        this.find = this.find.bind(this);
        this.findMore = this.findMore.bind(this);
        this.insert = this.insert.bind(this);
    }

    componentWillMount() {
        this.find();
    }

    find() {
        axios.get(URL)
        .then(response => this.setState({ itens: response.data }))
        .catch(() => console.log('erro ao buscar os itens'));
    }

    findMore() {
        pular += 10;

        axios.get(`${URL}?pular=${pular}`)
            .then(response => {
                if(Array.isArray(response.data)) {
                    const novaLista = this.state.itens.concat(response.data);
                    this.setState({ itens: novaLista });
                }
            })
            .catch(() => console.log('erro ao buscar mais itens'));
    }

    insert() {
        pular = 0;

        axios.post(URL)
            .then(response => this.find())
            .catch(() => console.log('erro ao inserir os itens'));
    }

    render() {
        const { itens } = this.state;

        if(itens.length <= 0) {
            return (
                <div className="container">
                    <i className="center-block fa fa-circle-o-notch fa-spin fa-3x fa-fw"></i>
                </div>
            );
        }
        else if(Array.isArray(itens)) {
            return (
                <div>
                    <table className="table table-striped table-hover">
                        <thead>
                            <tr>
                                <th>Arquivo</th>
                                <th>Categoria</th>
                                <th>Localização</th>
                                <th>Periodo</th>
                                <th>Sexo</th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                itens.map(iten => (
                                    <tr key={iten._id}>
                                        <td>{iten.arquivo}</td>
                                        <td>{iten.categoria}</td>
                                        <td>{iten.localizacao}</td>
                                        <td>{iten.periodo}</td>
                                        <td>{iten.sexo}</td>
                                    </tr>
                                ))
                            }
                        </tbody>
                    </table>
                    <Acoes
                        insert={this.insert}
                        findMore={this.findMore}/>
                </div>
            );
        }
        else {
            return (
                <tr key={itens._id}>
                    <td>{itens.arquivo}</td>
                    <td>{itens.categoria}</td>
                    <td>{itens.localizacao}</td>
                    <td>{itens.periodo}</td>
                    <td>{itens.sexo}</td>
                </tr>
            );
        }
    }
}

export default ListaPrincipal;
