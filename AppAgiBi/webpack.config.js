const webpack = require('webpack');

module.exports = {
    entry: './index.jsx',
    output: {
        path: __dirname + '/public',
        filename: 'app.js'
    },
    module: {
        loaders: [
            {
                test: /.js[x]$/,
                exclude: /node_modules/,
                loader: 'babel-loader',
                query: {
                    presets: ['react', 'es2015']
                }
            },
            {
                test: /.css$/,
                loader: ['style-loader', 'css-loader']
            },
            {
                test: /.svg|.eot|.woff|.woff2|.ttf/,
                loader: 'file-loader'
            }
        ]
    },
    resolve: {
        extensions: ['.js', '.jsx']
    }
}
