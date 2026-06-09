using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EF RID: 495
[Token(Token = "0x20001EF")]
public static class EncodeToTGAExtension
{
	// Token: 0x060009FE RID: 2558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x23F5460", Offset = "0x23F5460", VA = "0x7BBCBF5460")]
	public static byte[] EncodeToTGA(this Texture2D _texture2D, EncodeToTGAExtension.Compression _compression = EncodeToTGAExtension.Compression.RLE)
	{
		return null;
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00003E40 File Offset: 0x00002040
	[Token(Token = "0x60009FF")]
	[Address(RVA = "0x23F5F24", Offset = "0x23F5F24", VA = "0x7BBCBF5F24")]
	private static bool Equals(Color32 _first, Color32 _second)
	{
		return default(bool);
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00003E58 File Offset: 0x00002058
	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x23F5E08", Offset = "0x23F5E08", VA = "0x7BBCBF5E08")]
	private static EncodeToTGAExtension.RLEPacketType PacketType(Color32[] _arData, int _iPacketPosition)
	{
		return EncodeToTGAExtension.RLEPacketType.RLE;
	}

	// Token: 0x04000969 RID: 2409
	[Token(Token = "0x4000969")]
	[FieldOffset(Offset = "0x0")]
	private static readonly byte[] c_arV2Signature;

	// Token: 0x020001F0 RID: 496
	[Token(Token = "0x20001F0")]
	public enum Compression
	{
		// Token: 0x0400096B RID: 2411
		[Token(Token = "0x400096B")]
		None,
		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		RLE
	}

	// Token: 0x020001F1 RID: 497
	[Token(Token = "0x20001F1")]
	private enum RLEPacketType
	{
		// Token: 0x0400096E RID: 2414
		[Token(Token = "0x400096E")]
		RLE,
		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x400096F")]
		RAW
	}
}
