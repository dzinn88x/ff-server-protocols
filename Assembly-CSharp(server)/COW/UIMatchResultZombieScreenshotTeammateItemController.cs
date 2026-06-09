using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A75 RID: 6773
	[Token(Token = "0x2001A75")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F832C", Offset = "0x10F832C")]
	internal class UIMatchResultZombieScreenshotTeammateItemController : UIBaseController
	{
		// Token: 0x06008EA9 RID: 36521 RVA: 0x000260A0 File Offset: 0x000242A0
		[Token(Token = "0x6008EA9")]
		[Address(RVA = "0x1482304", Offset = "0x1482304", VA = "0x7BBBC82304")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008EAA RID: 36522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EAA")]
		[Address(RVA = "0x1482354", Offset = "0x1482354", VA = "0x7BBBC82354", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008EAB RID: 36523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EAB")]
		[Address(RVA = "0x14823B8", Offset = "0x14823B8", VA = "0x7BBBC823B8", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008EAC RID: 36524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EAC")]
		[Address(RVA = "0x1480F18", Offset = "0x1480F18", VA = "0x7BBBC80F18")]
		public void SetData(UIMatchResultZombieScreenshotController.MatchResultScreenshotData.TeammateData teammateData, uint all_damage, ulong mvp_id)
		{
		}

		// Token: 0x06008EAD RID: 36525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EAD")]
		[Address(RVA = "0x14823C0", Offset = "0x14823C0", VA = "0x7BBBC823C0")]
		public UIMatchResultZombieScreenshotTeammateItemController()
		{
		}

		// Token: 0x04009A4C RID: 39500
		[Token(Token = "0x4009A4C")]
		[FieldOffset(Offset = "0x58")]
		private UIMatchResultZombieScreenshotTeammateItemView m_View;
	}
}
