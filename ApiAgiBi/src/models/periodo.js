//dependencias
const connection = require('../config/connection');

class Periodo {
    find() {
        return connection()
            .then(Db => Db.collection('periodo'))
            .then(collection => collection.find().toArray())
            .then(documentos => {
                if(documentos.length > 0)
                    return documentos;

                return 'nenhum periodo encontrado';
            })
            .catch(() => 'erro');
    }
}

module.exports = Periodo;
