//dependencias
const connection = require('../config/connection');

class Arquivo {
    find() {
        return connection()
            .then(Db => Db.collection('arquivo'))
            .then(collection => collection.find().toArray())
            .then(documentos => {
                if(documentos.length > 0) 
                    return documentos;
                
                return 'nenhum arquivo encontrado';
            })
            .catch(() => 'erro');
    }
}

module.exports = Arquivo;
