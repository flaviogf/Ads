//dependencias react
import React, { Component } from 'react';

//componentes
import ListaPeriodo from './listaPeriodo';

class Periodo extends Component {
    render() {
        return (
            <div className="container-fluid">
                <div className="page-header">
                    <h2>Periodos</h2>
                </div>
                <ListaPeriodo />
            </div>
        );
    }
}

export default Periodo;
