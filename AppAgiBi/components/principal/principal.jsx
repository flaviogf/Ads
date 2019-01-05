//dependencias react
import React, { Component } from 'react';

//componentes
import ListaPrincipal from './listaPrincipal';

class Principal extends Component {
    render() {
        return (
            <div className="container-fluid">
                <div className="page-header">
                    <h2>Tabela Principal</h2>
                </div>
                <ListaPrincipal />
            </div>
        );
    }
}

export default Principal;
