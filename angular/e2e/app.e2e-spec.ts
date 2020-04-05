import { ReviewManiacsTemplatePage } from './app.po';

describe('ReviewManiacs App', function() {
  let page: ReviewManiacsTemplatePage;

  beforeEach(() => {
    page = new ReviewManiacsTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
