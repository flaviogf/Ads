import React, { Component } from 'react';
import { BrowserRouter, Route, Link } from 'react-router-dom';

//componentes
import Arquivo from '../arquivo/arquivo';
import Categoria from '../categoria/categoria';
import Localizacao from '../localizacao/localizacao';
import Periodo from '../periodo/periodo';
import Principal from '../principal/principal';
import Sexo from '../sexo/sexo';

class Navbar extends Component {
    render() {
        return (
            <BrowserRouter>
                <div>
                    <div className="navbar navbar-inverse">
                        <div className="container-fluid">
                            <div className="navbar-header">
                                <Link className="navbar-brand" to="/">AGI-BI</Link>
                            </div>

                            <div className="collapse navbar-collapse">
                                <ul className="nav navbar-nav">
                                    <li><Link to="/arquivo">Arquivo</Link></li>
                                    <li><Link to="/categoria">Categoria</Link></li>
                                    <li><Link to="/localizacao">Localizacao</Link></li>
                                    <li><Link to="/periodo">Periodo</Link></li>
                                    <li><Link to="/sexo">Sexo</Link></li>
                                    <li><Link to="/principal">Tabela Principal</Link></li>
                                </ul>
                            </div>
                        </div>
                    </div>

                    <Route path="/"/>
                    <Route path="/arquivo" component={Arquivo}/>
                    <Route path="/categoria" component={Categoria}/>
                    <Route path="/localizacao" component={Localizacao}/>
                    <Route path="/periodo" component={Periodo}/>
                    <Route path="/sexo" component={Sexo}/>
                    <Route path="/principal" component={Principal} />
                </div>
            </BrowserRouter>
        );
    }
}

export default Navbar;
