const path = require('path')
const webpack = require('webpack')
const CommonsChunkPlugin = require('webpack/lib/optimize/CommonsChunkPlugin')
const BundleAnalyzerPlugin = require('webpack-bundle-analyzer').BundleAnalyzerPlugin
const UglifyJsPlugin = require("webpack/lib/optimize/UglifyJsPlugin")

module.exports = {
    entry: {
        shared: ["./Scripts/app/index.js", "babel-polyfill", "vue", "vue-router"]
    },
    output: {
        filename: '[name].js',
        path: __dirname + "/wwwroot/js"
    },
    resolve: {
        alias: {
            'vue$': 'vue/dist/vue.esm.js'
        }
    },
    module: {
        loaders: [
            {
                test: /\.vue$/,
                loader: 'vue-loader',
                options: {

                }
            },
            {
                test: /.js$/,
                exclude: /node_modules/,
                loader: "babel-loader",
                query: {
                    presets: ['env']
                }
            },
            {
                test: /\.scss$/,
                use: ["style-loader", "css-loader", "sass-loader"]
            },
            {
                test: /\.css$/,
                use: ["style-loader", "css-loader"]
            },
            {
                test: /\.(ttf|eot|woff|woff2)$/,
                loader: 'file-loader?/bundle/name=assets/fonts/[name].[ext]'
            }

        ]
    },
    plugins: [
        new BundleAnalyzerPlugin(),
        new CommonsChunkPlugin({
            name: 'shared',
            minChunks: function (module) {
                return module.context && module.context.includes("node_modules")
            }
        }),
        new UglifyJsPlugin({
            test: /shared\.js/,
            minimize: true,
            filename: "shared.js.min",
            output: {
                comments: false,
                beautify: false
            }
        })
    ]
}