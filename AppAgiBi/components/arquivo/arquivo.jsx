//dependencias react
import React, { Component } from 'react';

//componentes
import ListaArquivo from './listaArquivo';

class Arquivo extends Component {
    render() {
        return (
            <div className="container-fluid">
                <div className="page-header">
                    <h2>Arquivos</h2>
                </div>
                <ListaArquivo />
            </div>
        );
    }
}

export default Arquivo;
