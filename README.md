# Coffe assistant - Unity - ROS - GPT

This repository is a part of the ICA project that aim's do solve the wozniak coffee test. In this section It was made a setup in Aumented Reality using an ai chat-bot to assist a persong step-by-step to serve a cup of coffe.

Sugestão usar 2 máquinas, com uso de linux para rodar os comandos ROS e uma máquina windows para rodar o Unity. Isso pode ser feito em dispositivos diferentes, ou em uma mesma máquina com a instalação de uma máquina virtual. 

# System Dependencies

Esse repositório é uma vertente do projeto I2CA. Para executar esse programa, primeiramente siga todas as instruções do repositório wozniak_coffe_test, pois esse programa faz uso do Coffe Assistant disponibilizado la.

# Setup do Óculos

Você deve ter também o aplicativo Meta Quest Link para desktop para conectar o óculos na sua máquina, e seguir o passo a passo sugerido no aplicativo para identificar o seu dispositivo da Meta. 

O óculos deve estar conectado via cabo para garantir o funcionamento perfeito via Unity.

Escanear o ambiente, e garantir que os 3 objetos a serem requisitados estejam presentes no ambiente e sejam escaneados e com a mesma tag, que deve ser a mesma especificada. Sugestão: coloque a tag "OTHER" pois o scan automático do óculos dificilmente coloca algum objeto com essa tag.  

# Setup Unity 

Instalar o unity hub e garantir que tenha uma licença de uso.

Instalar a versão 2022.3.32f1 do unity.

Clonar o projeto e adicionar ele aos seus projetos via unityhub. 

> Verificações dentro do projeto: 

Na hierarquia: 
>Selecione o componente ros holder
>No inspetor, veja os parâmetros do componente e garanta que o IP seja o mesmo da máquina que estará se comunicando com o unity.

>Selecione o componente scripts holder na hierarquia
>No inspetor, garanta que o parâmetro "Anchor_name" seja exatamente o mesmo nome das tags que você colocou nos objetos escaneados no passo a passo "Setup do óculos"
>Garanta que os parâmetros "obj1", "obj2" e "obj" sejam os objetos a serem requisitados na interação (para esse caso, "sweetener", "cup" e "coffe maker"). 


# Para executar o programa 

A conexão do Unity 

>launch rosbridge_server websocket_launch

>dar play no unity para estabelecar 

>launch servidor pick object 

>launch terminal chat

>quando estiver pronto para começar, sinalizar com o polegar