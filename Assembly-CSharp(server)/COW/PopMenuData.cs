using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AFF RID: 6911
	[Token(Token = "0x2001AFF")]
	public class PopMenuData
	{
		// Token: 0x060092E2 RID: 37602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092E2")]
		[Address(RVA = "0x1EFFEFC", Offset = "0x1EFFEFC", VA = "0x7BBC6FFEFC")]
		public PopMenuData()
		{
		}

		// Token: 0x04009D28 RID: 40232
		[Token(Token = "0x4009D28")]
		[FieldOffset(Offset = "0x10")]
		public string Text;

		// Token: 0x04009D29 RID: 40233
		[Token(Token = "0x4009D29")]
		[FieldOffset(Offset = "0x18")]
		public Action<object> Callback;

		// Token: 0x04009D2A RID: 40234
		[Token(Token = "0x4009D2A")]
		[FieldOffset(Offset = "0x20")]
		public object Data;

		// Token: 0x04009D2B RID: 40235
		[Token(Token = "0x4009D2B")]
		[FieldOffset(Offset = "0x28")]
		public bool Selected;

		// Token: 0x04009D2C RID: 40236
		[Token(Token = "0x4009D2C")]
		[FieldOffset(Offset = "0x29")]
		public bool CanSelect;

		// Token: 0x04009D2D RID: 40237
		[Token(Token = "0x4009D2D")]
		[FieldOffset(Offset = "0x2C")]
		public ResourceID spriteRes;

		// Token: 0x04009D2E RID: 40238
		[Token(Token = "0x4009D2E")]
		[FieldOffset(Offset = "0x30")]
		public string spritename;

		// Token: 0x04009D2F RID: 40239
		[Token(Token = "0x4009D2F")]
		[FieldOffset(Offset = "0x38")]
		public string SelectTip;
	}
}
