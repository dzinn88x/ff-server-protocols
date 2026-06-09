using System;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001616 RID: 5654
	[Token(Token = "0x2001616")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFA3C", Offset = "0x10EFA3C")]
	public class UISPHudVehicleStatsController : UIBaseController
	{
		// Token: 0x06006581 RID: 25985 RVA: 0x0001D040 File Offset: 0x0001B240
		[Token(Token = "0x6006581")]
		[Address(RVA = "0x1625FC8", Offset = "0x1625FC8", VA = "0x7BBBE25FC8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006582")]
		[Address(RVA = "0x1626018", Offset = "0x1626018", VA = "0x7BBBE26018", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006583 RID: 25987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006583")]
		[Address(RVA = "0x16260C4", Offset = "0x16260C4", VA = "0x7BBBE260C4", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006584")]
		[Address(RVA = "0x162631C", Offset = "0x162631C", VA = "0x7BBBE2631C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006585 RID: 25989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006585")]
		[Address(RVA = "0x1626534", Offset = "0x1626534", VA = "0x7BBBE26534")]
		private void OnHPChanged(params object[] data)
		{
		}

		// Token: 0x06006586 RID: 25990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006586")]
		[Address(RVA = "0x1626888", Offset = "0x1626888", VA = "0x7BBBE26888")]
		private void OnOBGetOn(params object[] data)
		{
		}

		// Token: 0x06006587 RID: 25991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006587")]
		[Address(RVA = "0x1626B74", Offset = "0x1626B74", VA = "0x7BBBE26B74")]
		private void OnOBGetOff(params object[] data)
		{
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006588")]
		[Address(RVA = "0x1626DFC", Offset = "0x1626DFC", VA = "0x7BBBE26DFC")]
		private void OnObserverSwitch(params object[] data)
		{
		}

		// Token: 0x06006589 RID: 25993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006589")]
		[Address(RVA = "0x1626D60", Offset = "0x1626D60", VA = "0x7BBBE26D60")]
		private void Clear()
		{
		}

		// Token: 0x0600658A RID: 25994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658A")]
		[Address(RVA = "0x16270CC", Offset = "0x16270CC", VA = "0x7BBBE270CC")]
		private void Update()
		{
		}

		// Token: 0x0600658B RID: 25995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658B")]
		[Address(RVA = "0x1627150", Offset = "0x1627150", VA = "0x7BBBE27150")]
		private void UpdateSpeed()
		{
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658C")]
		[Address(RVA = "0x16266DC", Offset = "0x16266DC", VA = "0x7BBBE266DC")]
		private void RefreshHP()
		{
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658D")]
		[Address(RVA = "0x1627374", Offset = "0x1627374", VA = "0x7BBBE27374")]
		public UISPHudVehicleStatsController()
		{
		}

		// Token: 0x040083C6 RID: 33734
		[Token(Token = "0x40083C6")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudVehicleStatsView m_View;

		// Token: 0x040083C7 RID: 33735
		[Token(Token = "0x40083C7")]
		[FieldOffset(Offset = "0x60")]
		private Vehicle m_Vehicle;

		// Token: 0x040083C8 RID: 33736
		[Token(Token = "0x40083C8")]
		private const int SPEED_SAMPLE_COUNT = 10;

		// Token: 0x040083C9 RID: 33737
		[Token(Token = "0x40083C9")]
		[FieldOffset(Offset = "0x68")]
		private float m_SpeedSum;

		// Token: 0x040083CA RID: 33738
		[Token(Token = "0x40083CA")]
		[FieldOffset(Offset = "0x70")]
		private Queue<float> m_Speeds;

		// Token: 0x040083CB RID: 33739
		[Token(Token = "0x40083CB")]
		[FieldOffset(Offset = "0x78")]
		private StringBuilder mLabelBuilder;

		// Token: 0x040083CC RID: 33740
		[Token(Token = "0x40083CC")]
		[FieldOffset(Offset = "0x80")]
		private int mLastSpeed;
	}
}
