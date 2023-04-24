# Way to process error

	if (!response.IsSuccessStatusCode)
	{
		var content = await response.Content.ReadAsStringAsync();

		throw new Exception($@"Cound not connect to {Client.BaseAddress}. Status Code: {response.StatusCode}, reason: {content}");
	}
	rs = await response.Content.ReadAsAsync<T>();