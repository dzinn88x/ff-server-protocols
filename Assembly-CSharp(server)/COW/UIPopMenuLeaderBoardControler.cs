using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B06 RID: 6918
	[Token(Token = "0x2001B06")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F930C", Offset = "0x10F930C")]
	public class UIPopMenuLeaderBoardControler : UIPopMenuSmallControler
	{
		// Token: 0x0600930F RID: 37647 RVA: 0x000271B0 File Offset: 0x000253B0
		[Token(Token = "0x600930F")]
		[Address(RVA = "0x20ED2DC", Offset = "0x20ED2DC", VA = "0x7BBC8ED2DC")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009310 RID: 37648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009310")]
		[Address(RVA = "0x20ED32C", Offset = "0x20ED32C", VA = "0x7BBC8ED32C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009311 RID: 37649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009311")]
		[Address(RVA = "0x20ED330", Offset = "0x20ED330", VA = "0x7BBC8ED330")]
		public void InitPopMenu(Func<FliterData, List<PopMenuData>> injectDataListAction, FliterData fliterData, PopUpStyle style = PopUpStyle.Down, int cellWidth = 260, float maxShowCount = 4.5f, bool enable = true)
		{
		}

		// Token: 0x06009312 RID: 37650 RVA: 0x000271C8 File Offset: 0x000253C8
		[Token(Token = "0x6009312")]
		[Address(RVA = "0x20ED4A8", Offset = "0x20ED4A8", VA = "0x7BBC8ED4A8", Slot = "36")]
		protected override bool CallDataInject()
		{
			return default(bool);
		}

		// Token: 0x06009313 RID: 37651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009313")]
		[Address(RVA = "0x20ED554", Offset = "0x20ED554", VA = "0x7BBC8ED554")]
		public PopMenuData FindPopMenuData(string fliter)
		{
			return null;
		}

		// Token: 0x06009314 RID: 37652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009314")]
		[Address(RVA = "0x20ED704", Offset = "0x20ED704", VA = "0x7BBC8ED704")]
		public UIPopMenuLeaderBoardControler()
		{
		}

		// Token: 0x04009D39 RID: 40249
		[Token(Token = "0x4009D39")]
		[FieldOffset(Offset = "0xA8")]
		private Func<FliterData, List<PopMenuData>> DataInjectWithParams;

		// Token: 0x04009D3A RID: 40250
		[Token(Token = "0x4009D3A")]
		[FieldOffset(Offset = "0xB0")]
		private FliterData FliterData;
	}
}
