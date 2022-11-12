# Основы ветвления

Предположим, вы работаете над проектом и уже имеете несколько коммитов.

![fff](https://git-scm.com/book/en/v2/images/basic-branching-1.png)

```markdown
$ git checkout -b iss53
Switched to a new branch "iss53"
```















Это то же самое что и:

```markdown
git branch iss53
git checkout iss53
```
















Вы решаете, что теперь вы будете заниматься проблемой #53 из вашей системы отслеживания ошибок. Чтобы создать ветку и сразу переключиться на нее, можно выполнить команду git checkout с параметром -b:

## Основные конфликты слияния

Иногда процесс не проходит гладко. Если вы изменили одну и ту же часть одного и того же файла по-разному в двух объединяемых ветках, Git не сможет их чисто объединить. Если ваше исправление ошибки #53 потребовало изменить ту же часть файла что и hotfix, вы получите примерно такое сообщение о конфликте слияния:

В этот момент вы получаете сообщение, что обнаружена критическая ошибка, требующая скорейшего исправления. Ваши действия:

1. Переключиться на основную ветку.

2. Создать ветку для добавления исправления.

3. После тестирования слить ветку содержащую исправление с основной веткой.

4. Переключиться назад в ту ветку, где вы пишете статью и продолжить работать.

```markdown
$ git merge iss53
Auto-merging index.html
CONFLICT (content): Merge conflict in index.html
Automatic merge failed; fix conflicts and then commit the result.
```

Git не создал коммит слияния автоматически. Он остановил процесс до тех пор, пока вы не разрешите конфликт. Чтобы в любой момент  после появления конфликта увидеть, какие файлы не объединены, вы можете запустить git status:
>Примечание
Мы рассмотрим более продвинутые инструменты для разрешения сложных конфликтов слияния в разделе Продвинутое слияние главы 7.

```markdown
$ git status
On branch master
You have unmerged paths.
  (fix conflicts and run "git commit")

Unmerged paths:
  (use "git add <file>..." to mark resolution)

    both modified:      index.html

no changes added to commit (use "git add" and/or "git commit -a")
```

Если это вас устраивает и вы убедились, что все файлы, где были конфликты, добавлены в индекс — выполните команду git commit для создания коммита слияния. Комментарий к коммиту слияния по умолчанию выглядит примерно так:

```markdown
Merge branch 'iss53'

Conflicts:
    index.html
#
# It looks like you may be committing a merge.
# If this is not correct, please remove the file
# .git/MERGE_HEAD
# and try again.


# Please enter the commit message for your changes. Lines starting
# with '#' will be ignored, and an empty message aborts the commit.
# On branch master
# All conflicts fixed but you are still merging.
#
# Changes to be committed:
# modified:   index.html
```

>Если вы считаете, что коммит слияния требует дополнительных пояснений — опишите как были разрешены конфликты и почему были применены именно такие изменения, если это не очевидно.
