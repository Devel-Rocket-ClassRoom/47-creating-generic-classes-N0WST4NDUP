using System;

public class Converter<TInput, TOutput>
{
    private Func<TInput, TOutput> _converter;
    public Converter(Func<TInput, TOutput> converter)
    {
        _converter = converter;
    }

    public TOutput Convert(TInput input) => _converter(input);

    public TOutput[] ConvertAll(TInput[] inputs)
    {
        TOutput[] result = new TOutput[inputs.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = _converter(inputs[i]);
        }
        return result;
    }
}