---
author: Lektion 14 
date: MMMM dd, YYYY
paging: "%d / %d"
---

# Lektion 14

Hej och välkommen!

## Agenda

1. Frågor och repetition
2. Genomgång av Git övningar
3. Grupparbete med handledning och avstämning
4. Introduktion till generics
5. Utmaning i grupp
6. Fortsättning på todo-app kopplat till generics
   1. Generisk repository (ArrayList men som filsparning)
   2. Schemaläggning och påminnelser

---

# Utmaning i grupp

Bygg en egen array list implementation `List<T>` som fungerar på alla datatyper. Implementera följande funktioner:
- `Add` Lägger till ett element i listan
- `Remove` Tar bort ett element från listan (objekt-referens)
- `RemoveAt` Tar bort ett element, baserat på index, från listan
- `Clear` Tömmer hela listan
- `Size` Returnerar antal element i listan
- `Get` Returnerar elementet på angiven plats (index)
- (extra om ni får tid) `SwapRemove` Byter plats på ett element, baserat på index, med det sista elementet och tar sedan bort det
- (extra om ni får tid) `Insert` Lägger in ett element på en specifik plats (index) och flyttar andra element
