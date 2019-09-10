module.exports = {
    devServer: {
        proxy: {
            '^/api': {
                target: 'https://localhost:5001',
                ws: true,
                changeOrigin: true
            }
        }
    },
    css: {
        loaderOptions: {
            less: {
                modifyVars: {
                    'primary-color': '#1da1f2'
                }
            }
        }
    }
}