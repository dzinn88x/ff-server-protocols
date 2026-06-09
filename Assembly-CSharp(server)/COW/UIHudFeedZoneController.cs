using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018BF RID: 6335
	[Token(Token = "0x20018BF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4BFC", Offset = "0x10F4BFC")]
	internal class UIHudFeedZoneController : UIBaseController
	{
		// Token: 0x06007E1A RID: 32282 RVA: 0x00022860 File Offset: 0x00020A60
		[Token(Token = "0x6007E1A")]
		[Address(RVA = "0x1C0B470", Offset = "0x1C0B470", VA = "0x7BBC40B470")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007E1B RID: 32283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E1B")]
		[Address(RVA = "0x1C0B4C0", Offset = "0x1C0B4C0", VA = "0x7BBC40B4C0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E1C RID: 32284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E1C")]
		[Address(RVA = "0x1C0B620", Offset = "0x1C0B620", VA = "0x7BBC40B620", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007E1D RID: 32285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E1D")]
		[Address(RVA = "0x1C0B6EC", Offset = "0x1C0B6EC", VA = "0x7BBC40B6EC")]
		private void OnShowFeedZone(params object[] datas)
		{
		}

		// Token: 0x06007E1E RID: 32286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E1E")]
		[Address(RVA = "0x1C0B908", Offset = "0x1C0B908", VA = "0x7BBC40B908")]
		private void OnFeedClick()
		{
		}

		// Token: 0x06007E1F RID: 32287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E1F")]
		[Address(RVA = "0x1C0BA78", Offset = "0x1C0BA78", VA = "0x7BBC40BA78")]
		public UIHudFeedZoneController()
		{
		}

		// Token: 0x06007E20 RID: 32288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E20")]
		[Address(RVA = "0x1C0BA8C", Offset = "0x1C0BA8C", VA = "0x7BBC40BA8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142C18", Offset = "0x1142C18")]
		private void <OnFeedClick>b__8_0()
		{
		}

		// Token: 0x04009168 RID: 37224
		[Token(Token = "0x4009168")]
		[FieldOffset(Offset = "0x58")]
		private UIHudFeedZoneView m_View;

		// Token: 0x04009169 RID: 37225
		[Token(Token = "0x4009169")]
		[FieldOffset(Offset = "0x60")]
		private ushort m_Feedid;

		// Token: 0x0400916A RID: 37226
		[Token(Token = "0x400916A")]
		[FieldOffset(Offset = "0x64")]
		protected float m_EnableFeedTime;

		// Token: 0x0400916B RID: 37227
		[Token(Token = "0x400916B")]
		[FieldOffset(Offset = "0x68")]
		private uint m_delaycall;
	}
}
