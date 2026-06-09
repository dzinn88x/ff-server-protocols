using System;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW
{
	// Token: 0x020019F0 RID: 6640
	[Token(Token = "0x20019F0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7464", Offset = "0x10F7464")]
	public class UILobbyBonusEventInfoController : UIBaseController
	{
		// Token: 0x06008953 RID: 35155 RVA: 0x00024E70 File Offset: 0x00023070
		[Token(Token = "0x6008953")]
		[Address(RVA = "0x1528B24", Offset = "0x1528B24", VA = "0x7BBBD28B24")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008954 RID: 35156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008954")]
		[Address(RVA = "0x1528B74", Offset = "0x1528B74", VA = "0x7BBBD28B74", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008955 RID: 35157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008955")]
		[Address(RVA = "0x1528EF8", Offset = "0x1528EF8", VA = "0x7BBBD28EF8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008956 RID: 35158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008956")]
		[Address(RVA = "0x1528FA4", Offset = "0x1528FA4", VA = "0x7BBBD28FA4")]
		public void OnExpBonusClick()
		{
		}

		// Token: 0x06008957 RID: 35159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008957")]
		[Address(RVA = "0x15291FC", Offset = "0x15291FC", VA = "0x7BBBD291FC")]
		public void OnGoldBonusClick()
		{
		}

		// Token: 0x06008958 RID: 35160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008958")]
		[Address(RVA = "0x1529454", Offset = "0x1529454", VA = "0x7BBBD29454")]
		public void OnGoldLimitClick()
		{
		}

		// Token: 0x06008959 RID: 35161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008959")]
		[Address(RVA = "0x15296AC", Offset = "0x15296AC", VA = "0x7BBBD296AC")]
		public void OnDebrisLimitClick()
		{
		}

		// Token: 0x0600895A RID: 35162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600895A")]
		[Address(RVA = "0x1529904", Offset = "0x1529904", VA = "0x7BBBD29904")]
		public void RefreshBonusEventInfo(MapModeData mapModeData, zTfbhtW groupMode)
		{
		}

		// Token: 0x0600895B RID: 35163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600895B")]
		[Address(RVA = "0x1528DC0", Offset = "0x1528DC0", VA = "0x7BBBD28DC0")]
		public void HideItems()
		{
		}

		// Token: 0x0600895C RID: 35164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600895C")]
		[Address(RVA = "0x1529F58", Offset = "0x1529F58", VA = "0x7BBBD29F58")]
		public UILobbyBonusEventInfoController()
		{
		}

		// Token: 0x04009778 RID: 38776
		[Token(Token = "0x4009778")]
		[FieldOffset(Offset = "0x58")]
		private UILobbyBonusEventInfoView m_View;

		// Token: 0x04009779 RID: 38777
		[Token(Token = "0x4009779")]
		[FieldOffset(Offset = "0x60")]
		private UIModelGameBonusEvent m_ModelGameBonusEvent;

		// Token: 0x0400977A RID: 38778
		[Token(Token = "0x400977A")]
		[FieldOffset(Offset = "0x68")]
		private GameBonusEventDesc m_EventDesc;

		// Token: 0x0400977B RID: 38779
		[Token(Token = "0x400977B")]
		[FieldOffset(Offset = "0x70")]
		private uint m_DelayCall;

		// Token: 0x020019F1 RID: 6641
		[Token(Token = "0x20019F1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F749C", Offset = "0x10F749C")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x0600895D RID: 35165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600895D")]
			[Address(RVA = "0x1529F50", Offset = "0x1529F50", VA = "0x7BBBD29F50")]
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x0600895E RID: 35166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600895E")]
			[Address(RVA = "0x1529F60", Offset = "0x1529F60", VA = "0x7BBBD29F60")]
			internal void <RefreshBonusEventInfo>b__0()
			{
			}

			// Token: 0x0600895F RID: 35167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600895F")]
			[Address(RVA = "0x1529FA0", Offset = "0x1529FA0", VA = "0x7BBBD29FA0")]
			internal void <RefreshBonusEventInfo>b__1()
			{
			}

			// Token: 0x0400977C RID: 38780
			[Token(Token = "0x400977C")]
			[FieldOffset(Offset = "0x10")]
			public UILobbyBonusEventInfoController <>4__this;

			// Token: 0x0400977D RID: 38781
			[Token(Token = "0x400977D")]
			[FieldOffset(Offset = "0x18")]
			public MapModeData mapModeData;

			// Token: 0x0400977E RID: 38782
			[Token(Token = "0x400977E")]
			[FieldOffset(Offset = "0x20")]
			public zTfbhtW groupMode;
		}
	}
}
