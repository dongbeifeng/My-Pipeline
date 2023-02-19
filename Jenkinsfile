pipeline {
    agent any
    stages {
        stage('build') {
            steps {
                bat 'dotnet test'
                bat 'dotnet build -o build'
            }
        }
    }
}