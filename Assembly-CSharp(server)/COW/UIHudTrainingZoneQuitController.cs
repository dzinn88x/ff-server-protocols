using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001981 RID: 6529
	[Token(Token = "0x2001981")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6644", Offset = "0x10F6644")]
	public class UIHudTrainingZoneQuitController : UIBaseController
	{
		// Token: 0x0600850A RID: 34058 RVA: 0x00024138 File Offset: 0x00022338
		[Token(Token = "0x600850A")]
		[Address(RVA = "0x15E9BB4", Offset = "0x15E9BB4", VA = "0x7BBBDE9BB4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600850B RID: 34059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600850B")]
		[Address(RVA = "0x15E9C04", Offset = "0x15E9C04", VA = "0x7BBBDE9C04", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600850C RID: 34060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600850C")]
		[Address(RVA = "0x15E9E4C", Offset = "0x15E9E4C", VA = "0x7BBBDE9E4C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600850D RID: 34061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600850D")]
		[Address(RVA = "0x15EA000", Offset = "0x15EA000", VA = "0x7BBBDEA000")]
		private void OnTrainingZoneChanged(params object[] data)
		{
		}

		// Token: 0x0600850E RID: 34062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600850E")]
		[Address(RVA = "0x15EA098", Offset = "0x15EA098", VA = "0x7BBBDEA098")]
		private void OnMiniGameStart(params object[] data)
		{
		}

		// Token: 0x0600850F RID: 34063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600850F")]
		[Address(RVA = "0x15EA144", Offset = "0x15EA144", VA = "0x7BBBDEA144")]
		private void OnMiniGameClose(params object[] data)
		{
		}

		// Token: 0x06008510 RID: 34064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008510")]
		[Address(RVA = "0x15EA154", Offset = "0x15EA154", VA = "0x7BBBDEA154")]
		private void OnBtnBack()
		{
		}

		// Token: 0x06008511 RID: 34065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008511")]
		[Address(RVA = "0x15EA4B4", Offset = "0x15EA4B4", VA = "0x7BBBDEA4B4")]
		public UIHudTrainingZoneQuitController()
		{
		}

		// Token: 0x040094E1 RID: 38113
		[Token(Token = "0x40094E1")]
		[FieldOffset(Offset = "0x58")]
		private UIHudTrainingZoneQuitView m_View;
	}
}
