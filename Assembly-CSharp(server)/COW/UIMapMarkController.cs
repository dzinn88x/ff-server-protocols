using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A60 RID: 6752
	[Token(Token = "0x2001A60")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F80BC", Offset = "0x10F80BC")]
	internal class UIMapMarkController : UIBaseController
	{
		// Token: 0x06008E1B RID: 36379 RVA: 0x00025ED8 File Offset: 0x000240D8
		[Token(Token = "0x6008E1B")]
		[Address(RVA = "0x146AB80", Offset = "0x146AB80", VA = "0x7BBBC6AB80")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008E1C RID: 36380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E1C")]
		[Address(RVA = "0x146ABD0", Offset = "0x146ABD0", VA = "0x7BBBC6ABD0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008E1D RID: 36381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E1D")]
		[Address(RVA = "0x146AC34", Offset = "0x146AC34", VA = "0x7BBBC6AC34", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008E1E RID: 36382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E1E")]
		[Address(RVA = "0x146AC3C", Offset = "0x146AC3C", VA = "0x7BBBC6AC3C")]
		public void SetMarkColor(int teamIndex)
		{
		}

		// Token: 0x06008E1F RID: 36383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E1F")]
		[Address(RVA = "0x146AD0C", Offset = "0x146AD0C", VA = "0x7BBBC6AD0C")]
		public UIMapMarkController()
		{
		}

		// Token: 0x040099D4 RID: 39380
		[Token(Token = "0x40099D4")]
		[FieldOffset(Offset = "0x58")]
		private UIMapMarkView m_View;
	}
}
