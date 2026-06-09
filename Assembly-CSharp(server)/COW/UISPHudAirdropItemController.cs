using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B84 RID: 7044
	[Token(Token = "0x2001B84")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA3DC", Offset = "0x10FA3DC")]
	public class UISPHudAirdropItemController : UIBaseController
	{
		// Token: 0x060097D1 RID: 38865 RVA: 0x00028038 File Offset: 0x00026238
		[Token(Token = "0x60097D1")]
		[Address(RVA = "0x1A26E04", Offset = "0x1A26E04", VA = "0x7BBC226E04")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060097D2 RID: 38866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D2")]
		[Address(RVA = "0x1A26E54", Offset = "0x1A26E54", VA = "0x7BBC226E54", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060097D3 RID: 38867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D3")]
		[Address(RVA = "0x1A2707C", Offset = "0x1A2707C", VA = "0x7BBC22707C")]
		public void SetData(int idx, List<^yE\u007FRJO> pickups, Vector3 position)
		{
		}

		// Token: 0x060097D4 RID: 38868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D4")]
		[Address(RVA = "0x1A274EC", Offset = "0x1A274EC", VA = "0x7BBC2274EC")]
		private void OnAirdropClick()
		{
		}

		// Token: 0x060097D5 RID: 38869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D5")]
		[Address(RVA = "0x1A276D0", Offset = "0x1A276D0", VA = "0x7BBC2276D0")]
		public void SetSelected(bool selected)
		{
		}

		// Token: 0x060097D6 RID: 38870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097D6")]
		[Address(RVA = "0x1A27730", Offset = "0x1A27730", VA = "0x7BBC227730")]
		public UISPHudAirdropItemController()
		{
		}

		// Token: 0x04009FCE RID: 40910
		[Token(Token = "0x4009FCE")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudAirdropItemView m_View;

		// Token: 0x04009FCF RID: 40911
		[Token(Token = "0x4009FCF")]
		[FieldOffset(Offset = "0x60")]
		private List<UISprite> m_Items;

		// Token: 0x04009FD0 RID: 40912
		[Token(Token = "0x4009FD0")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_AirdropPos;

		// Token: 0x04009FD1 RID: 40913
		[Token(Token = "0x4009FD1")]
		[FieldOffset(Offset = "0x74")]
		private int m_Index;
	}
}
