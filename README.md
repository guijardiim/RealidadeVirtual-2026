# 🏛️ Museu Histórico Interativo

![Plataforma](https://img.shields.io/badge/Platform-Android-brightgreen)
![Engine](https://img.shields.io/badge/Engine-Unity%206-blue)
![Status](https://img.shields.io/badge/Status-Conclu%C3%ADdo-success)

O **Museu Histórico Interativo** é um aplicativo móvel em Realidade Virtual (RV) projetado para o cenário de educação imersiva. O projeto materializa um ambiente tridimensional onde o usuário pode navegar em primeira pessoa por um acervo cultural, estimulando o letramento digital e o Pensamento Computacional.

---

## 🚀 Funcionalidades e Diferenciais

* **Navegação Imersiva:** Exploração em primeira pessoa otimizada para dispositivos móveis Android.
* **Feedback Auditivo Espacializado:** Ao se aproximar de uma obra de arte, um gatilho lógico aciona um áudio explicativo que contextualiza a peça histórica para o usuário.
* **Sistema de Barreiras Invisíveis:** Bloqueios perimetrais com avisos sonoros que impedem o usuário de evadir a área projetada do cenário, refinando a orientação espacial.
* **Interface Personalizada:** Aplicativo totalmente integrado ao sistema Android com ícone minimalista estilizado.

---

## 🛠️ Engenharia de Desenvolvimento e Otimizações

Para viabilizar a execução fluida de malhas tridimensionais complexas em hardware móvel limitado, o projeto aplicou as seguintes soluções na engine **Unity 6**:

1. **Proxy Geometry (Interatividade):** Uso de colisores invisíveis (`Triggers`) e componentes `RigidBody` para contornar a restrição de malha única do cenário, permitindo mapear interações por proximidade via evento `OnTriggerEnter`.
2. **Iluminação em Tempo Real (Realtime):** Configuração de luzes dinâmicas para eliminar o overhead computacional e o tempo excessivo de processamento que seriam exigidos pelo cálculo de mapas de luz (*Lightmapping*).
3. **Pipeline de Ativos Simplificado:** Ajustes globais nas diretrizes de importação de malhas e texturas no *Player Settings*, garantindo uma taxa de quadros (*framerate*) estável no Android.

---

## 📱 Requisitos e Instalação

* **Plataforma-alvo:** Android (Smartphone)
* **Engine utilizada:** Unity 6

### Como testar:
1. Baixe o arquivo `.apk` disponível na seção de [Releases](link-para-as-releases-se-houver).
2. Transfira o arquivo para o seu dispositivo Android.
3. Permita a instalação de fontes desconhecidas nas configurações do aparelho e instale o aplicativo.

---

## 👥 Autores

* **Guilherme de Melo Jardim** - *Desenvolvimento Técnico e Otimização Gráfica*
* **Tauani Vitória Ferreira** - *Pesquisa Teórica, Curadoria de Conteúdo e Roteirização*

---
*Projeto desenvolvido como artigo e protótipo prático para o curso de Ciência da Computação – Unisagrado (Bauru/SP).*
