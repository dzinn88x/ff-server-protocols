using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A52 RID: 6738
	[Token(Token = "0x2001A52")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7F34", Offset = "0x10F7F34")]
	public class UIManualMapEvtItemController : UIBaseController, ITipsDelegate
	{
		// Token: 0x06008DBA RID: 36282 RVA: 0x00025C38 File Offset: 0x00023E38
		[Token(Token = "0x6008DBA")]
		[Address(RVA = "0x18E2B00", Offset = "0x18E2B00", VA = "0x7BBC0E2B00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008DBB RID: 36283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DBB")]
		[Address(RVA = "0x18E2B50", Offset = "0x18E2B50", VA = "0x7BBC0E2B50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DBC")]
		[Address(RVA = "0x18E2D54", Offset = "0x18E2D54", VA = "0x7BBC0E2D54", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008DBD RID: 36285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DBD")]
		[Address(RVA = "0x18E2D5C", Offset = "0x18E2D5C", VA = "0x7BBC0E2D5C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DBE")]
		[Address(RVA = "0x18E2330", Offset = "0x18E2330", VA = "0x7BBC0E2330")]
		public void SetData(ManualInMapData data, float scale = 1f)
		{
		}

		// Token: 0x06008DBF RID: 36287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DBF")]
		[Address(RVA = "0x18E233C", Offset = "0x18E233C", VA = "0x7BBC0E233C")]
		public void RefreshView()
		{
		}

		// Token: 0x06008DC0 RID: 36288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DC0")]
		[Address(RVA = "0x18E2E54", Offset = "0x18E2E54", VA = "0x7BBC0E2E54")]
		private void SetIcon(UISprite icon, ManualInMapData data)
		{
		}

		// Token: 0x06008DC1 RID: 36289 RVA: 0x00025C50 File Offset: 0x00023E50
		[Token(Token = "0x6008DC1")]
		[Address(RVA = "0x18E2FD4", Offset = "0x18E2FD4", VA = "0x7BBC0E2FD4")]
		private bool CheckIsUnlock(uint evtId)
		{
			return default(bool);
		}

		// Token: 0x06008DC2 RID: 36290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DC2")]
		[Address(RVA = "0x18E3140", Offset = "0x18E3140", VA = "0x7BBC0E3140")]
		private void OnClickMore()
		{
		}

		// Token: 0x06008DC3 RID: 36291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DC3")]
		[Address(RVA = "0x18E3230", Offset = "0x18E3230", VA = "0x7BBC0E3230", Slot = "28")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06008DC4 RID: 36292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DC4")]
		[Address(RVA = "0x18E3370", Offset = "0x18E3370", VA = "0x7BBC0E3370")]
		public void OnTweenFinish()
		{
		}

		// Token: 0x06008DC5 RID: 36293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DC5")]
		[Address(RVA = "0x18E33B4", Offset = "0x18E33B4", VA = "0x7BBC0E33B4")]
		public UIManualMapEvtItemController()
		{
		}

		// Token: 0x06008DC6 RID: 36294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DC6")]
		[Address(RVA = "0x18E33BC", Offset = "0x18E33BC", VA = "0x7BBC0E33BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11445A0", Offset = "0x11445A0")]
		private void <RefreshView>b__11_0()
		{
		}

		// Token: 0x040099A1 RID: 39329
		[Token(Token = "0x40099A1")]
		[FieldOffset(Offset = "0x58")]
		private UIManualMapEvtItemView m_View;

		// Token: 0x040099A2 RID: 39330
		[Token(Token = "0x40099A2")]
		[FieldOffset(Offset = "0x60")]
		private ManualInMapData m_Data;

		// Token: 0x040099A3 RID: 39331
		[Token(Token = "0x40099A3")]
		[FieldOffset(Offset = "0x68")]
		private float m_Scale;

		// Token: 0x040099A4 RID: 39332
		[Token(Token = "0x40099A4")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_ShowDelayCallID;

		// Token: 0x040099A5 RID: 39333
		[Token(Token = "0x40099A5")]
		[FieldOffset(Offset = "0x70")]
		private TweenAlpha m_TweenAlpha;

		// Token: 0x040099A6 RID: 39334
		[Token(Token = "0x40099A6")]
		[FieldOffset(Offset = "0x78")]
		private UIScrollView m_LabelScrollView;

		// Token: 0x02001A53 RID: 6739
		[Token(Token = "0x2001A53")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7F6C", Offset = "0x10F7F6C")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06008DC7 RID: 36295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008DC7")]
			[Address(RVA = "0x18E3138", Offset = "0x18E3138", VA = "0x7BBC0E3138")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06008DC8 RID: 36296 RVA: 0x00025C68 File Offset: 0x00023E68
			[Token(Token = "0x6008DC8")]
			[Address(RVA = "0x18E3494", Offset = "0x18E3494", VA = "0x7BBC0E3494")]
			internal bool <CheckIsUnlock>b__0(uint e)
			{
				return default(bool);
			}

			// Token: 0x040099A7 RID: 39335
			[Token(Token = "0x40099A7")]
			[FieldOffset(Offset = "0x10")]
			public uint evtId;
		}
	}
}
