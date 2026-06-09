using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BEC RID: 11244
	[Token(Token = "0x2002BEC")]
	public class SDKIAPTaskInfo
	{
		// Token: 0x0600F8A8 RID: 63656 RVA: 0x000479B8 File Offset: 0x00045BB8
		[Token(Token = "0x600F8A8")]
		[Address(RVA = "0x273A5D0", Offset = "0x273A5D0", VA = "0x7BBCF3A5D0")]
		public static bool Equals(SDKIAPTaskInfo a, SDKIAPTaskInfo b)
		{
			return default(bool);
		}

		// Token: 0x0600F8A9 RID: 63657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8A9")]
		[Address(RVA = "0x273A654", Offset = "0x273A654", VA = "0x7BBCF3A654")]
		public string IdentifySelf()
		{
			return null;
		}

		// Token: 0x0600F8AA RID: 63658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8AA")]
		[Address(RVA = "0x273A6A8", Offset = "0x273A6A8", VA = "0x7BBCF3A6A8")]
		public SDKIAPTaskInfo()
		{
		}

		// Token: 0x04011C9C RID: 72860
		[Token(Token = "0x4011C9C")]
		[FieldOffset(Offset = "0x10")]
		public string Delegate;

		// Token: 0x04011C9D RID: 72861
		[Token(Token = "0x4011C9D")]
		[FieldOffset(Offset = "0x18")]
		public string Identifier;

		// Token: 0x04011C9E RID: 72862
		[Token(Token = "0x4011C9E")]
		[FieldOffset(Offset = "0x20")]
		public int ServerID;

		// Token: 0x04011C9F RID: 72863
		[Token(Token = "0x4011C9F")]
		[FieldOffset(Offset = "0x24")]
		public int RoleID;

		// Token: 0x04011CA0 RID: 72864
		[Token(Token = "0x4011CA0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SDKIAPTaskInfo Empty;
	}
}
