module.exports = {
    devServer: {
        proxy: {
            '^/api': {
                target: 'https://localhost:44341',
                ws: true,
                changeOrigin: trues
            }
        }
    }
}