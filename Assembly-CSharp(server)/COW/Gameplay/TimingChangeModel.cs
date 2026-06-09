using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002BA2 RID: 11170
	[Token(Token = "0x2002BA2")]
	internal class TimingChangeModel : MonoBehaviour, IUIModelDataChangeObserver
	{
		// Token: 0x0600F6FF RID: 63231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6FF")]
		[Address(RVA = "0x16CB5B8", Offset = "0x16CB5B8", VA = "0x7BBBECB5B8")]
		private void Start()
		{
		}

		// Token: 0x0600F700 RID: 63232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F700")]
		[Address(RVA = "0x16CB664", Offset = "0x16CB664", VA = "0x7BBBECB664")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600F701 RID: 63233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F701")]
		[Address(RVA = "0x16CB680", Offset = "0x16CB680", VA = "0x7BBBECB680", Slot = "4")]
		public void OnDataChanged(UIBaseModel yOY[vZi, uint ez[`XN[, params object[] OSvO{nh)
		{
		}

		// Token: 0x0600F702 RID: 63234 RVA: 0x00046E48 File Offset: 0x00045048
		[Token(Token = "0x600F702")]
		[Address(RVA = "0x16CBDD4", Offset = "0x16CBDD4", VA = "0x7BBBECBDD4", Slot = "5")]
		public uint GetInterestedPropID(UIBaseModel yOY[vZi)
		{
			return 0U;
		}

		// Token: 0x0600F703 RID: 63235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F703")]
		[Address(RVA = "0x16CBE18", Offset = "0x16CBE18", VA = "0x7BBBECBE18")]
		public TimingChangeModel()
		{
		}

		// Token: 0x04011AF7 RID: 72439
		[Token(Token = "0x4011AF7")]
		[FieldOffset(Offset = "0x18")]
		public int m_ChangeModelTime;

		// Token: 0x04011AF8 RID: 72440
		[Token(Token = "0x4011AF8")]
		[FieldOffset(Offset = "0x20")]
		public string m_ModleID;

		// Token: 0x04011AF9 RID: 72441
		[Token(Token = "0x4011AF9")]
		[FieldOffset(Offset = "0x28")]
		public string m_ChangeEffectID;

		// Token: 0x04011AFA RID: 72442
		[Token(Token = "0x4011AFA")]
		[FieldOffset(Offset = "0x30")]
		public string m_ChangeSoundID;

		// Token: 0x04011AFB RID: 72443
		[Token(Token = "0x4011AFB")]
		[FieldOffset(Offset = "0x38")]
		public GameObject m_Modle;

		// Token: 0x04011AFC RID: 72444
		[Token(Token = "0x4011AFC")]
		[FieldOffset(Offset = "0x40")]
		private UIModelMatch xUo^\u0082io;
	}
}
