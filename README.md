## Web API

- Decode params from route

Do not use [FromRoute] when values might contain %2f (that is /) because %2f won't be escaped to /. Use [FromQuery] if the value might contain %2f