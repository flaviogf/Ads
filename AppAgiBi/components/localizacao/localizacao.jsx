//dependencias react
import React, { Component } from 'react';

//componentes
import ListaLocalizacao from './listaLocalizacao';

class Localizacao extends Component {
    render() {
        return (
            <div className="container-fluid">
                <div className="page-header">
                    <h2>Localizações</h2>
                </div>
                <ListaLocalizacao />
            </div>
        );
    }
}

export default Localizacao;
