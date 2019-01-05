//dependencias
const MongoClient = require('mongodb').MongoClient;

const URI = 'mongodb://admin:admin@ds137230.mlab.com:37230/agi-bi';

const connection = () => {
    return MongoClient.connect(URI);
}

module.exports = connection;
