//dependencias react
import React, { Component } from 'react';

//componentes
import ListaCategoria from './listaCategoria';

class Categoria extends Component {
    render() {
        return (
            <div className="container-fluid">
                <div className="page-header">
                    <h2>Categorias</h2>
                </div>
                <ListaCategoria />
            </div>
        );
    }
}

export default Categoria;
