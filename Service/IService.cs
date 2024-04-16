public interface IService
{
  List<WordsTheme> GetWordsThemes(String levelToFind);
  WordsTheme GetWordsThemesById(String id);
}