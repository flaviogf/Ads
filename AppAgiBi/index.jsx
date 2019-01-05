//font-awesome
import './node_modules/font-awesome/css/font-awesome.css';

//dependencias bootstrap
import './node_modules/bootstrap/dist/css/bootstrap.min.css';

//css personalizado
import './custom.css';

//dependencias react
import React from 'react';
import ReactDOM from 'react-dom';

//componentes
import App from './components/main/app';

ReactDOM.render(<App />, document.getElementById('app'));
