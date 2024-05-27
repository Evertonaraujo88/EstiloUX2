describe('template spec', () => {

  before(() => {
    cy.visit('/')
  })

  beforeEach(() => {
    cy.viewport("iphone-xr")
  })


  it('passes', () => {
    cy.get("[aria-label='title-head']").should("be.visible")
    cy.get("[aria-label='title-head']").should("contain", "Good morning")
  })

  it("Verificar se existe itens na listagem das playlists", () => {
    cy.wait(2000)
    cy.get("[aria-label='playlist-item']").should("have.length.greaterThan", 0)
  })

  it("Clicar no primeiro item da lista, para listar suas músicas", () => {
    cy.get("[aria-label='playlist-item']").first().click();
    // cy.get("[aria-label='music-item']").first().click();
    cy.scrollTo("top")

  })

  it("Clicar na música desejada e executar o áudio", () => {
    cy.get("[aria-label='music-item']").eq(3).click()
  })
})