//dependencias react
import React, { Component } from 'react';

//componentes
import ListaSexo from './listaSexo';

class Sexo extends Component {
    render() {
        return (
            <div className="container-fluid">
                <div className="page-header">
                    <h2>Sexos</h2>
                </div>
                <ListaSexo />
            </div>
        );
    }
}

export default Sexo;
