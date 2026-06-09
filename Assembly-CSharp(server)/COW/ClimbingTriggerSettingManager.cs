using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011B2 RID: 4530
	[Token(Token = "0x20011B2")]
	public class ClimbingTriggerSettingManager : SingletonModule<ClimbingTriggerSettingManager>
	{
		// Token: 0x0600467E RID: 18046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600467E")]
		[Address(RVA = "0x14F9F68", Offset = "0x14F9F68", VA = "0x7BBBCF9F68", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600467F")]
		[Address(RVA = "0x14F9F6C", Offset = "0x14F9F6C", VA = "0x7BBBCF9F6C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004680")]
		[Address(RVA = "0x14FA2EC", Offset = "0x14FA2EC", VA = "0x7BBBCFA2EC")]
		private Dictionary<uint, ClimbingTriggerSettingData> LoadClimbingTriggerSettings(ResourceID resID)
		{
			return null;
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004681")]
		[Address(RVA = "0x14FA4C4", Offset = "0x14FA4C4", VA = "0x7BBBCFA4C4")]
		public ClimbingTriggerSettingData GetClimbingTriggerSetting(uint map_id, uint mode_id, uint climbing_trigger_id)
		{
			return null;
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004682")]
		[Address(RVA = "0x14FA5A8", Offset = "0x14FA5A8", VA = "0x7BBBCFA5A8")]
		public ClimbingTriggerSettingManager()
		{
		}

		// Token: 0x040057DC RID: 22492
		[Token(Token = "0x40057DC")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, Dictionary<uint, ClimbingTriggerSettingData>> m_ClimbingTriggerSettings;
	}
}
