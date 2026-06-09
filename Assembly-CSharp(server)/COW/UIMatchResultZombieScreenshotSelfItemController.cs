using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A74 RID: 6772
	[Token(Token = "0x2001A74")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F82F4", Offset = "0x10F82F4")]
	internal class UIMatchResultZombieScreenshotSelfItemController : UIBaseController
	{
		// Token: 0x06008EA4 RID: 36516 RVA: 0x00026088 File Offset: 0x00024288
		[Token(Token = "0x6008EA4")]
		[Address(RVA = "0x1481E70", Offset = "0x1481E70", VA = "0x7BBBC81E70")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008EA5 RID: 36517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EA5")]
		[Address(RVA = "0x1481EC0", Offset = "0x1481EC0", VA = "0x7BBBC81EC0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008EA6 RID: 36518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EA6")]
		[Address(RVA = "0x1482060", Offset = "0x1482060", VA = "0x7BBBC82060", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008EA7 RID: 36519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EA7")]
		[Address(RVA = "0x148094C", Offset = "0x148094C", VA = "0x7BBBC8094C")]
		public void SetData(UIMatchResultZombieScreenshotController.MatchResultScreenshotData data)
		{
		}

		// Token: 0x06008EA8 RID: 36520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EA8")]
		[Address(RVA = "0x1482068", Offset = "0x1482068", VA = "0x7BBBC82068")]
		public UIMatchResultZombieScreenshotSelfItemController()
		{
		}

		// Token: 0x04009A49 RID: 39497
		[Token(Token = "0x4009A49")]
		[FieldOffset(Offset = "0x58")]
		private UIMatchResultZombieScreenshotSelfItemView m_View;

		// Token: 0x04009A4A RID: 39498
		[Token(Token = "0x4009A4A")]
		[FieldOffset(Offset = "0x60")]
		private UIBaseProfileInfoController m_Profile;

		// Token: 0x04009A4B RID: 39499
		[Token(Token = "0x4009A4B")]
		[FieldOffset(Offset = "0x68")]
		private UIBriefProfileInfoController m_BriefProfile;
	}
}
