﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charon_Hash_Detector.Core
{
    class LegalConfig
    {
        public static string Legal_disclaimer_content()
        {
            string software_name = "Charon Hash Detector";
            string programmer_name = "AmirHossein Ghanmi (Ch4120N)";
            string programmer_email = "Ch4120ni@Gmail.com";
            string content = $@"
<{software_name}> Copyright 2024 <{programmer_name}>
This Program Is Free Software: You Can Redistribute It And/Or Modify It Under The Terms Of The Charon General Black License As Published By The Black Hacking Software Foundation.
Terms and Conditions for Copying, Distribution, and Modification:

Non-use of other licenses:

Software or tools distributed under the CGBL license cannot utilize other licenses.
This clause is designed to maintain integrity and consistency in the use of this license.

Permitted Use:

This software is designed solely for legal and ethical use.
Usage for educational purposes, legal penetration testing, and security evaluation is permitted.
Any unauthorized use, including illegal hacking, data theft, or unauthorized system intrusion, is prohibited.

Usage Conditions:

Users must ensure that all their activities comply with local, national, and international laws.
Users must obtain necessary permissions from system owners before conducting any penetration testing or related security activities.

User Responsibility:

Users are responsible for any use of the software and must report all their activities transparently and document them.
Users must not use the software to create, distribute, or execute malicious code (such as viruses, trojans, and malware).

Data Protection:

Users must comply with all data protection and privacy laws.
Users must not collect, store, or process personal or sensitive information without explicit permission from the owners.

Distribution of Modifications:

Any modifications or changes to this software must be distributed under the same original license and include all the terms and conditions of this license.
Users must fully document all changes and publish a copy of the documentation along with the modified software.

Developer Commitments:

The developer commits to providing the software with high ethical and legal standards and ensuring no intentional backdoors, vulnerabilities, or malicious features exist in the software.
The developer assumes no responsibility for misuse, illegal use, or unethical behavior by users; all responsibilities and liabilities rest with the users.
The developer reserves the right to update and amend the terms of this license at any time, with or without prior notice to users.

License Termination:

This license will automatically terminate if any of the above conditions are violated, and users must immediately cease using the software.
The developer reserves the right to block access to the software for users who violate the terms of the license at any time and without prior notice and may take legal action against such users.
Upon termination of the license, users must destroy all copies of the software in their possession and confirm in writing to the developer that this condition has been met.

Disclaimer of Warranty:

This software is provided 'as is', without any express or implied warranty, including but not limited to warranties of merchantability, fitness for a particular purpose, and non-infringement.
The developer does not warrant that the software will meet users' requirements, that the operation of the software will be uninterrupted or error-free, or that any defects identified will be corrected.
Users assume all risks associated with the use of this software, including but not limited to risks of data loss, system damage, or any other adverse effects resulting from the use or misuse of the software.

Limitation of Liability:

In no event shall the developer be liable for any direct, indirect, incidental, special, exemplary, or consequential damages(including but not limited to loss of use, data, or profits) arising from or in connection with the use or performance of this software, whether in contract, tort, or otherwise, even if advised of the possibility of such damages.
The developer's total liability arising from or in connection with this license or the use of the software shall not exceed the amount paid by the user for the software, if any.

Contact Information:

For inquiries, support, or feedback, users can contact {programmer_name} directly at {programmer_email}.
";
            return content;
        }
    }
}
