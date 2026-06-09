using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001916 RID: 6422
	[Token(Token = "0x2001916")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F57F4", Offset = "0x10F57F4")]
	internal class UIHudMVEController : UIHudButtonBaseController
	{
		// Token: 0x06008181 RID: 33153 RVA: 0x00023400 File Offset: 0x00021600
		[Token(Token = "0x6008181")]
		[Address(RVA = "0x15BBF30", Offset = "0x15BBF30", VA = "0x7BBBDBBF30")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008182 RID: 33154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008182")]
		[Address(RVA = "0x15BBF80", Offset = "0x15BBF80", VA = "0x7BBBDBBF80", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008183 RID: 33155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008183")]
		[Address(RVA = "0x15BC188", Offset = "0x15BC188", VA = "0x7BBBDBC188", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008184")]
		[Address(RVA = "0x15BC2FC", Offset = "0x15BC2FC", VA = "0x7BBBDBC2FC", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008185 RID: 33157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008185")]
		[Address(RVA = "0x15BC344", Offset = "0x15BC344", VA = "0x7BBBDBC344", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008186")]
		[Address(RVA = "0x15BC494", Offset = "0x15BC494", VA = "0x7BBBDBC494")]
		private void Update()
		{
		}

		// Token: 0x06008187 RID: 33159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008187")]
		[Address(RVA = "0x15BC914", Offset = "0x15BC914", VA = "0x7BBBDBC914")]
		private void OnEquipChange(params object[] data)
		{
		}

		// Token: 0x06008188 RID: 33160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008188")]
		[Address(RVA = "0x15BC9BC", Offset = "0x15BC9BC", VA = "0x7BBBDBC9BC")]
		private void OnSwitchObserver(params object[] param)
		{
		}

		// Token: 0x06008189 RID: 33161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008189")]
		[Address(RVA = "0x15BC348", Offset = "0x15BC348", VA = "0x7BBBDBC348")]
		private void UpdateShowHide()
		{
		}

		// Token: 0x0600818A RID: 33162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600818A")]
		[Address(RVA = "0x15BC9C0", Offset = "0x15BC9C0", VA = "0x7BBBDBC9C0")]
		private void OnEnergyChange(params object[] data)
		{
		}

		// Token: 0x0600818B RID: 33163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600818B")]
		[Address(RVA = "0x15BCAE8", Offset = "0x15BCAE8", VA = "0x7BBBDBCAE8")]
		public UIHudMVEController()
		{
		}

		// Token: 0x04009337 RID: 37687
		[Token(Token = "0x4009337")]
		[FieldOffset(Offset = "0x60")]
		private UIHudMVEView m_View;
	}
}
