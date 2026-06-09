using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001889 RID: 6281
	[Token(Token = "0x2001889")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F44C4", Offset = "0x10F44C4")]
	internal class UIHudBuffListItemController : UIBaseController
	{
		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06007C51 RID: 31825 RVA: 0x000222D8 File Offset: 0x000204D8
		// (set) Token: 0x06007C52 RID: 31826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700098B")]
		public [shICQ^ BuffBevTypeID
		{
			[Token(Token = "0x6007C51")]
			[Address(RVA = "0x189FF40", Offset = "0x189FF40", VA = "0x7BBC09FF40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114292C", Offset = "0x114292C")]
			get
			{
				return [shICQ^.BuffBehavior_Default;
			}
			[Token(Token = "0x6007C52")]
			[Address(RVA = "0x18A01C4", Offset = "0x18A01C4", VA = "0x7BBC0A01C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114293C", Offset = "0x114293C")]
			set
			{
			}
		}

		// Token: 0x06007C53 RID: 31827 RVA: 0x000222F0 File Offset: 0x000204F0
		[Token(Token = "0x6007C53")]
		[Address(RVA = "0x18A01CC", Offset = "0x18A01CC", VA = "0x7BBC0A01CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007C54 RID: 31828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C54")]
		[Address(RVA = "0x18A021C", Offset = "0x18A021C", VA = "0x7BBC0A021C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007C55 RID: 31829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C55")]
		[Address(RVA = "0x18A001C", Offset = "0x18A001C", VA = "0x7BBC0A001C")]
		public void SetUIData(SIljDGq bevData)
		{
		}

		// Token: 0x06007C56 RID: 31830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C56")]
		[Address(RVA = "0x18A0280", Offset = "0x18A0280", VA = "0x7BBC0A0280")]
		protected void Update()
		{
		}

		// Token: 0x06007C57 RID: 31831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C57")]
		[Address(RVA = "0x189FF48", Offset = "0x189FF48", VA = "0x7BBC09FF48")]
		public void UpdateLifeTime(float life)
		{
		}

		// Token: 0x06007C58 RID: 31832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C58")]
		[Address(RVA = "0x18A032C", Offset = "0x18A032C", VA = "0x7BBC0A032C")]
		private void UpdateCDProgress()
		{
		}

		// Token: 0x06007C59 RID: 31833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C59")]
		[Address(RVA = "0x18A0428", Offset = "0x18A0428", VA = "0x7BBC0A0428")]
		public UIHudBuffListItemController()
		{
		}

		// Token: 0x04009057 RID: 36951
		[Token(Token = "0x4009057")]
		[FieldOffset(Offset = "0x58")]
		private UIHudBuffListItemView m_View;

		// Token: 0x04009058 RID: 36952
		[Token(Token = "0x4009058")]
		[FieldOffset(Offset = "0x60")]
		public BountyPickupStatus BountyStatus;

		// Token: 0x04009059 RID: 36953
		[Token(Token = "0x4009059")]
		[FieldOffset(Offset = "0x64")]
		private float m_TotalLife;

		// Token: 0x0400905A RID: 36954
		[Token(Token = "0x400905A")]
		[FieldOffset(Offset = "0x68")]
		private float m_CurrentLife;

		// Token: 0x0400905B RID: 36955
		[Token(Token = "0x400905B")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F9AC", Offset = "0x112F9AC")]
		private [shICQ^ <BuffBevTypeID>k__BackingField;
	}
}
