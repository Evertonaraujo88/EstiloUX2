describe('template spec', () => {
  before(() => {
    cy.visit('/')
  })

  beforeEach(() => {
    cy.viewport("iphone-xr")
  })

  it('passes', () => {

    //capturar o elemento tittle e ver se ele está visivel
    cy.get("[aria-label='title-head']").should("be.visible")
    cy.get("[aria-label='title-head']").should("contain", "Good morning")
  })

  it('Entrar em uma playlist aleatória', () => {
    cy.wait(2000)
    cy.get("[aria-label='playlist-item']").eq(1).click()
  })


  it('Entrar em uma música aleatória', () => {
    cy.get("[aria-label='music-item']").eq(2).click()
  })

  it('Voltar para a home', () => {
    cy.wait(2000)
    cy.get("[aria-label='back-home']").click()
  });

})