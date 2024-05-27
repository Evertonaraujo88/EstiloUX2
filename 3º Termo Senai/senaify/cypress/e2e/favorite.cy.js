describe('template spec', () => {
  before(() => {
    cy.visit('/')
  })

  beforeEach(() => {
    cy.viewport("iphone-xr")
  })

  it('Redirecionar minha tela para a tela de busca', () => {
    cy.get("[href='/Favorites']").click()


  })

  it('Tocar musica favoritada', () => {
    cy.get("[aria-label='favorite-music']").eq(2).click()

    cy.scrollTo("top")
  });

})