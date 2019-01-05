//dependencias
const connection = require('../config/connection');

class Sexo {
    find() {
        return connection()
            .then(Db => Db.collection('sexo'))
            .then(collection => collection.find().toArray())
            .then(documentos => {
                if(documentos.length > 0)
                    return documentos;

                return 'nenhum sexo encontrado';
            })
            .catch(() => 'erro');
    }
}

module.exports = Sexo;
