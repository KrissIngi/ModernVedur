# This is to document the design and code assumptions, and limitations of this solution.

## Major Assumptions
- **Vedur API:**
  - One of the biggest ones it that I'm trusting that this is always available and will never go down, as there is no cache in the program for this data.
  - I'm trusting that they won't change the XML calls for the next few days/weeks.
- **User Input:**
  - I trust that the users will enter a station that is already in the list I have setup.
  - Trust that they will use Reykjavík instead of Hafnarfjörður or other places in the Höfuðborgarsvæðið.
- **Map:** 
   - That the users won't need to see the exact location on the map for that weather station.

## Design Decisions
- **Asynchronous Programming:**
  - Used for enhancing performance and not to overload the main thread.
- **Razor Pages Framework:**
  - Chosen for its simplicity and .Net integrations.

## Limitations
  - There is litle error handling in the solution.
  - There is limitation on the user input, I trust them maybe a bit too much.
  - This is only in Icelandic.
  - Mobile could be better, but major limitation in the iFrame from Veður.is
  - iFrame from Veður.is had to be copied for adding HTTPS into the URLS.
