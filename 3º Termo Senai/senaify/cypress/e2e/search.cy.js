describe('teste da tela de pesquisa', () => {
  before(() => {
    cy.visit('/')
  })

  beforeEach(() => {
    cy.viewport("iphone-xr")
  })

  it('Redirecionar minha tela para a tela de busca', () => {
    cy.get("[href='/Search']").click()

    //cy.scrollTo("top")
  })

  it("Procurar por uma música", () => {
    cy.get("[data-testid='campoBusca']").type("Margiela Split Toes")
    cy.get("[aria-label='music-item']").should("have.length.greaterThan", 0)
  })

  it("Verificar se tem uma música exata", () => {
    cy.get("[aria-label='music-item']").filter(":contains('Margiela Split Toes')").click;

  });

  it("clicou no botão curtir", async () => {
    cy.wait(2000)

    cy.get("[aria-label='music-item']").first().then((item) => {
      cy.get(item).click()
      cy.wrap(item).find("[data-testid='icon-button']").click()
    })
  })
})