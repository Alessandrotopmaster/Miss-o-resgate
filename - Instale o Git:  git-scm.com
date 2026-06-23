git init
git add .
git commit -m "Primeira versão: estrutura e arquivos iniciais"
git branch -M main
git remote add origin https://github.com/SEU_USUARIO/missao-resgate.git
git push -u origin main
